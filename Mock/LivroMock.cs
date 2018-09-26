using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Mock
{
    public static class LivroMock
    {
        public static List<Livro> LivrosMockados()
        {
            List<Livro> livros = new List<Livro>();

            livros.Add(new Livro() {
                Id = 1,
                Titulo = "Ontem não te vi em Babilónia",
                Autor = "António Lobo Antunes",
                Personagens = new List<Personagem>(){ new Personagem() { Id = 0, Nome = "William" }, new Personagem() { Id = 1, Nome = "Ana" }, new Personagem() { Id = 3, Nome = "Lauro" } }
            });

            livros.Add(new Livro()
            {
                Id = 2,
                Titulo = "Eu receberia as piores notícias dos seus lindos lábios",
                Autor = "Marçal Aquino",
                Personagens = new List<Personagem>() { new Personagem() { Id = 0, Nome = "Estevam" }, new Personagem() { Id = 1, Nome = "Tarik" }, new Personagem() { Id = 3, Nome = "Cristian" } }
            });

            livros.Add(new Livro()
            {
                Id = 3,
                Titulo = "A insustentável leveza do ser",
                Autor = "Milan Kundera",
                Personagens = new List<Personagem>() { new Personagem() { Id = 0, Nome = "Harry" }, new Personagem() { Id = 1, Nome = "Percy" }, new Personagem() { Id = 3, Nome = "Godofredo" } }
            });

            return livros;
        }
        
    }
}
