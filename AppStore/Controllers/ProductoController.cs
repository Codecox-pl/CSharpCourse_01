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
            return View();
        }

        public IActionResult Delete() 
        {
            return RedirectToAction(nameof(ProductoList));
        }

        public IActionResult ProductoList()
        {
            return View();
        }
    }
}
