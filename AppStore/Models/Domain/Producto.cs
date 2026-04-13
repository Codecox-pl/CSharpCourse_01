using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppStore.Models.Domain
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string? NombrePro { get; set; }
        public string? Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public ICollection<Categoria>? CategoriaRelationList { get; set; }
        public ICollection<CategoriaProducto>? ProductoCategoriaRelationList { get; set; }

        [NotMapped]
        public List<int> Categorias { get; set; } = new List<int>();
        [NotMapped]
        public string? CategoriasNames { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? CategoriasList { get; set; }
        [NotMapped]
        public MultiSelectList? MultiCategoriasList { get; set; }
        [NotMapped]
        public string? Imagen { get; internal set; }
    }
}
