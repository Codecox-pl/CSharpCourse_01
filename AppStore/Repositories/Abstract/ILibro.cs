using AppStore.Models.Domain;
using AppStore.Models.DTO;

namespace AppStore.Repositories.Abstract
{
    public interface ILibro
    {
        bool Add(Producto producto);
        bool Update(Producto producto);

        Producto GetById(int id);

        bool Delete(int id);

        ProductoListVm List(string term = "", bool paggin = false, int currentPage = 0);

        List<int> GetCategoriaByProductoId(int productoId);
    }
}
