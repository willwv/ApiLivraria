using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Livro
    {
        [Required]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public List<Personagem> Personagens { get; set; }
    }
}