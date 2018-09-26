using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Mock;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class LivrosController : Controller
    {
        /// <summary>
        /// Obtém todos os livros cadastrados.
        /// </summary>
        [HttpGet]
        public List<Livro> ObterTodosLivros()
        {
            return LivroMock.LivrosMockados();
        }

        /// <summary>
        /// Obtém dados de um livro cadastrado, filtrado pelo nome de um usuário.
        /// </summary>
        /// <param name="nomePersonagem">Nome de um personagem.</param>
        [HttpGet("{nomePersonagem}/personagem")]
        public List<Livro> ObterLivrosPorNomePersonagem(string nomePersonagem)
        {
            List<Livro> livros = LivroMock.LivrosMockados();
            List<Livro> livrosPorPersonagens = new List<Livro>();

            livros.ForEach(livro => {
                livro.Personagens.ForEach(personagem => {
                    if (personagem.Nome == nomePersonagem) {
                        livrosPorPersonagens.Add(livro);
                    }
                });
            });

            return livrosPorPersonagens;
        }

        /// <summary>
        /// Obtém dados de um livro filtrado pelo nome de um autor.
        /// </summary>
        /// <param name="nomeAutor">Nome de um autor.</param>
        [HttpGet("{nomeAutor}/autor")]
        public IEnumerable<string> ObterLivrosPorNomeAutor(string nomeAutor)
        {
            List<Livro> livros = LivroMock.LivrosMockados();

            var autores = from livro in livros
                          where livro.Autor == nomeAutor
                          select livro.Titulo;

            return autores;
        }

        /// <summary>
        /// Cadastra um novo livro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Livro
        ///     {
        ///        "Id": "int",
        ///        "Titulo": "string",
        ///        "Autor": "string"
        ///     }
        ///
        /// </remarks>
        /// <param name="dadosLivros">Informações sobre o livro.</param>
        [HttpPost]
        public void CriarNovoLivro([FromBody]Livro dadosLivros)
        {
        }

        /// <summary>
        /// Cadastra um novo livro.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /comentario
        ///     {
        ///        "comentario": "string",
        ///     }
        ///
        /// </remarks>
        /// <param name="comentario">Comentario sobre o livro.</param>        
        /// <param name="id">Id do livro.</param>

        [HttpPost("{id}/comentarios")]
        public void CriarComentarioSobreLivro(int id, [FromBody]string comentario)
        {
        }
    }
}