using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class EditorasController
    {
        /// <summary>
        /// Cadastra uma nova Editora.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Editora
        ///     {
        ///        "Id": "int",
        ///        "Nome": "string",
        ///        "Endereco": "string"
        ///     }
        ///
        /// </remarks>
        /// <param name="editora">Informações sobre o editora.</param>
        [HttpPost]
        public void Post([FromBody]Editora editora)
        {
        }
    }
}
