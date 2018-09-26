using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class PedidosController
    {
        /// <summary>
        /// Cria um novo pedido.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Pedido
        ///     {
        ///        "Id": "int",
        ///        "NomeCliente": "string",
        ///        "Valor": "double"
        ///     }
        ///
        /// </remarks>
        /// <param name="pedido">Alterações feitas no pedido.</param>
        [HttpPost("")]
        public void CriarPedido([FromBody]Pedido pedido)
        {
        }

        /// <summary>
        /// Altera um pedido.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Pedido
        ///     {
        ///        "Valor": "double"
        ///     }
        ///
        /// </remarks>
        /// <param name="id">Id do pedido a ser alterado.</param>
        /// <param name="pedido">Alterações feitas no pedido.</param>
        [HttpPut("{id}")]
        public void AlterarPedido(int id, [FromBody]Pedido pedido)
        {
        }
    }
}
