using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeliculaAPI.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int categoriaId { get; set; }
        [ForeignKey("categoriaId")]
        public Categoria Categoria { get; set; }

        public int PeliculasFIlmadas {get; set;}

    }
}
