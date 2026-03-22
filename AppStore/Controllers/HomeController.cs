using AppStore.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AppStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductoService _productoService;

        public HomeController(IProductoService productoService) 
        { 
          _productoService = productoService;
        }

        public IActionResult Index(string term= "", int currentPage = 1)
        {
            var productos = _productoService.List(term,true,currentPage);


            return View(productos);
        }

        public IActionResult ProductoDetail(int productoId)
        {
            var producto =  _productoService.GetById(productoId);

            return View(producto);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
