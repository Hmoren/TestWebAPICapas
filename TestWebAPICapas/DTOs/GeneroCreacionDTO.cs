using System.ComponentModel.DataAnnotations;

namespace TestWebAPICapas.DTOs
{
    public class GeneroCreacionDTO
    {
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength:50)]
        public string Nombre { get; set; }        
        public string Direccion { get; set; }
    }
}
