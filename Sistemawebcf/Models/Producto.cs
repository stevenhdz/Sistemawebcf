using System.ComponentModel.DataAnnotations;

namespace Sistemawebcf.Models
{
    public class Producto
    {
        public int idproducto { get; set; }
        [Required(ErrorMessage ="Seleccione una categoría.")]
        public int idcategoria { get; set; }
        [StringLength(64,
            ErrorMessage = "El código no debe de tener más de 64 caracteres.")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre.")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "El nombre no debe de tener más de 100 caracteres, ni menos de 3 caracteres.")]
        public string nombre { get; set; }
        [Required(ErrorMessage ="Ingrese un precio de venta.")]
        public decimal precio_venta { get; set; }
        [Required(ErrorMessage ="Ingrese un stock")]
        public int stock { get; set; }
        [StringLength(255,
            ErrorMessage = "la descripción no debe de tener más de 255 caracteres.")]
        public string descripcion { get; set; }
        public bool? estado { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
