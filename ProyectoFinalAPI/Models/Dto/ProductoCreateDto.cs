using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalAPI.Models.Dto
{
    public class ProductoCreateDto
    {
        [Required]
        [StringLength(50)]
        public string TipoProducto { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
    }
}
