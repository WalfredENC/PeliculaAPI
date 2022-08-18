﻿using System.ComponentModel.DataAnnotations;

namespace PeliculaAPI.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Lista { get; set; }
        public DateTime? FechaCreacion { get; set; }
        //Probando comando stash.
        //
        //

    }
}
