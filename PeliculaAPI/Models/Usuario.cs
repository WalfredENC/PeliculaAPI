using System.ComponentModel.DataAnnotations;

namespace PeliculaAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Identificador {get; set;}
        
        public string? Nombre {get; set;}
        public string? UsuarioA { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int Edad {get; set}
    }
}
