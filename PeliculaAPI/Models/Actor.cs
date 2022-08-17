using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeliculaAPI.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        //Saludos amigos.
    }
}
