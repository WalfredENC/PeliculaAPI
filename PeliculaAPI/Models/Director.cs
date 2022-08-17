using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeliculaAPI.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? RutaImagen { get; set; }
        public string? Descripcion { get; set; }
        public string? Duracion { get; set; }

    }
}
