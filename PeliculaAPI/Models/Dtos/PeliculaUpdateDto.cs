using System.ComponentModel.DataAnnotations;
using static PeliculaAPI.Models.Pelicula;

namespace PeliculaAPI.Models.Dtos
{
    public class PeliculaUpdateDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "La duración es obligatoria")]
        public string? Duracion { get; set; }
        public TipoClasificacion Clasificacion { get; set; }
        public int categoriaId { get; set; }
    }
}
