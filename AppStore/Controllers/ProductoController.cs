using AppStore.Models.Domain;
using AppStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppStore.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoService productoService;
        private readonly IFileService fileService;
        private readonly ICategoriaService categoriaService;

        public ProductoController(IProductoService productoService, IFileService fileService, ICategoriaService categoriaService)
        {
            this.productoService = productoService;
            this.fileService = fileService;
            this.categoriaService = categoriaService;
        }

        [HttpPost]
        public IActionResult Add(Producto producto)
        {
            producto.CategoriasList = categoriaService.List().Select(a => new SelectListItem { Text = a.Nombre, Value = a.CategoriaId.ToString() });

            if (!ModelState.IsValid)
            {
                return View(producto);
            }

            if(producto.ImageFile != null)
            {
                var resultado = fileService.SaveImage(producto.ImageFile);
                if(resultado.Item1 == 0)
                {
                    TempData["msg"] = "La imagen no pudo guardarse exitosamente";
                    return View(producto);
                }

                var imagenName = resultado.Item2;
                producto.Imagen = imagenName;
            }

            var resultadoProducto = productoService.Add(producto);
            if(resultadoProducto)
            {
                TempData["msg"] = "Se agrego el libro exitosamente";
                return RedirectToAction(nameof(Add));
            }

            TempData["msg"] = "Errores guardando el libro";

            return View(producto);
        }

        

        public IActionResult Add()
        {
            var producto = new Producto();

            // Llenamos la lista manualmente para probar
            producto.CategoriasList = new List<SelectListItem>
    {
        new SelectListItem { Text = "Prueba 1", Value = "1" },
        new SelectListItem { Text = "Prueba 2", Value = "2" }
    };

            return View(producto);
        }

        public IActionResult Edit(int id) 
        {
            var producto = productoService.GetById(id);
            var categoriasDeProducto = productoService.GetCategoriaByProductoId(id);
            var multiSelectListCategorias = new MultiSelectList(categoriaService.List(), "Id", "Nombre", categoriasDeProducto);

            producto.MultiCategoriasList = multiSelectListCategorias;
            return View(producto);
        }
        [HttpPost]
        public IActionResult Edit (Producto producto)
        {
            var categoriasDeProducto = productoService.GetCategoriaByProductoId(producto.ProductoId);
            var multiSelectListCategorias = new MultiSelectList(categoriaService.List(), "Id", "Nombre", categoriasDeProducto);

            producto.MultiCategoriasList = multiSelectListCategorias;

            if(!ModelState.IsValid) 
            {
              return View(producto);
            }

            if(producto.ImageFile != null) 
            { 
              var fileResultado = fileService.SaveImage(producto.ImageFile);
                if(fileResultado.Item1 == 0)
                {
                    TempData["msg"] = "La imagen no fue guardada";
                    return View(producto);
                }

                var imagenName = fileResultado.Item2;
                producto.Imagen = imagenName;

            }

            var resultadoProducto = productoService.Update(producto);

            if(!resultadoProducto)
            {
                TempData["msg"] = "Errores, no se pudo actualizar el producto";
                return View(producto);
            }

            TempData["msg"] = "Se actualizo exitosamente el producto";
            return View(producto);
        }

        public IActionResult Delete(int id) 
        {
            productoService.Delete(id);
            return RedirectToAction(nameof(ProductoList));
        }

        public IActionResult ProductoList()
        {
            var productos = productoService.List();
            return View(productos);
        }
    }
}
