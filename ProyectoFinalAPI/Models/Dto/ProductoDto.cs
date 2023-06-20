using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalAPI.Models.Dto
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }
        [Required]
        [StringLength(50)]
        public string TipoProducto { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
    }
}
