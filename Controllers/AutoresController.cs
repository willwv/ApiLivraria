using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class AutoresController
    {
        /// <summary>
        /// Cadastra um novo Autor.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Autor
        ///     {
        ///        "Id": "int",
        ///        "Nome": "string",
        ///        "Email": "string",
        ///        "Telefone": "string"
        ///     }
        ///
        /// </remarks>
        /// <param name="autor">Informações sobre o autor.</param>
        [HttpPost]
        public void CriarAutor([FromBody]Autor autor)
        {
        }
    }
}
