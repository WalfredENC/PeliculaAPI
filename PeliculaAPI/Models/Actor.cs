using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeliculaAPI.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? RutaImagen { get; set; }
        public string? Descripcion { get; set; }
        //Emmanuel Nájera Castrejón
        public string? Duracion { get; set; }
        public enum TipoClasificacion { Siete, Trece, Dieciseis, Dieciocho }
        public TipoClasificacion Clasificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int categoriaId { get; set; }
        [ForeignKey("categoriaId")]
        public Categoria Categoria { get; set; }

        public int PeliculasFIlmadas {get; set;}

    }
}
