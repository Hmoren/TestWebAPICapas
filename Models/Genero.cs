using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        //public string Descripcion { get; set; }
        public string Direccion { get; set; }
    }
}
