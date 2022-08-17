using System.ComponentModel.DataAnnotations;
using static PeliculaAPI.Models.Pelicula;

namespace PeliculaAPI.Models.Dtos
{
    public class PeliculaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El id es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? RutaImagen { get; set; }
        [Required(ErrorMessage = "La ruta de la imagen es obligatoria")]
        public IFormFile? Foto { get; set; }
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string? Duracion { get; set; }
        public TipoClasificacion Clasificacion { get; set; }
        public int categoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
