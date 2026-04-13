using AppStore.Models.Domain;
using AppStore.Models.DTO;
using AppStore.Repositories.Abstract;

namespace AppStore.Repositories.Implementation
{
    public class ProductoService: IProductoService
    {

        private readonly DatabaseContext ctx;

        public ProductoService(DatabaseContext ctxParemeter) 
        { 
          ctx = ctxParemeter;
        }

        public bool Add(Producto producto)
        {
            try
            {
                ctx.Productos.Add(producto);
                ctx.SaveChanges();

                // Si la lista está vacía, el foreach simplemente no se ejecuta
                // pero ya no lanzará una excepción.
                if (producto.Categorias != null)
                {
                    foreach (var categoriaId in producto.Categorias)
                    {
                        var productoCategoria = new CategoriaProducto
                        {
                            ProductoId = producto.ProductoId,
                            CategoriaId = categoriaId,
                        };
                        ctx.CategoriaProductos.Add(productoCategoria);
                    }
                    ctx.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = GetById(id);
                if(data is null) 
                {
                    return false;
                }

                var productoCategoria = ctx.CategoriaProductos.Where(a => a.ProductoId == data.ProductoId);
                ctx.CategoriaProductos.RemoveRange(productoCategoria);
                ctx.Productos.Remove(data);
                ctx.SaveChanges();

                return true;
            }catch (Exception) 
            {
                return false;
            }
        }

        public Producto GetById(int id)
        {
            return ctx.Productos.Find(id)!;
        }

        public List<int> GetCategoriaByProductoId(int productoId)
        {
            return ctx.CategoriaProductos!.Where( a => a.ProductoId ==  productoId).Select(a => a.CategoriaId).ToList();

        }

        public ProductoListVm List(string term = "", bool paggin = false, int currentPage = 0)
        {
            var data = new ProductoListVm();

            var list = ctx.Productos.ToList();

            if(!string.IsNullOrEmpty(term))
            {
                term = term.ToLower();
                list = list.Where(a => a.NombrePro!.ToLower().StartsWith(term)).ToList();
            }

            if(paggin)
            {
                int pageSize = 5;
                int count = list.Count;
                int TotalPages =(int)Math.Ceiling(count/(double)pageSize);
                list.Skip((currentPage-1) *pageSize).Take(pageSize).ToList();
                data.PageSize = pageSize;
                data.CurrentPage = currentPage;
                data.TotalPages = TotalPages;
            }

            foreach (var producto in list)
            {
                var categorias = (
                    from categoria in ctx.Categorias
                    join lc in ctx.CategoriaProductos
                    on categoria.CategoriaId equals lc.CategoriaId
                    where lc.ProductoId == producto.ProductoId

                    select categoria.Nombre
                    ).ToList();
                var categoriaNombres = string.Join(",", categorias);
                producto.CategoriasNames = categoriaNombres;
            }

            data.ProductoList = list.AsQueryable();

            return data;
        }

        public bool Update(Producto producto)
        {
            try
            {
                var categoriasParaEliminar = ctx.CategoriaProductos.Where(a => a.ProductoId == producto.ProductoId);

                foreach (var categoria in categoriasParaEliminar)
                {
                    ctx.CategoriaProductos.Remove(categoria);
                }

                foreach (var categoriaId in producto.Categorias!)
                {
                    var productoCategoria = new CategoriaProducto
                    {
                        CategoriaId = categoriaId,
                        ProductoId = producto.ProductoId
                    };

                    ctx.CategoriaProductos!.Add(productoCategoria);
                }

                ctx.Productos!.Update(producto);
                ctx.SaveChanges();

                return true;

            }
            catch (Exception) 
            {
                return false;
            }
        }
    }
}
