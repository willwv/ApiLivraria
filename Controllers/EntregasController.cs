using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Mock;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class EntregasController
    {
        /// <summary>
        /// Obtém dados de uma entrega pelo ID.
        /// </summary>
        /// <param name="id">ID da entrega.</param>
        [HttpGet("{id}")]
        public IEnumerable<Entrega> ObterEntrega(int id)
        {
            List<Entrega> entregas = EntregaMock.EntregasMockadas();

            return from entrega in entregas
                   where entrega.Id == id
                   select entrega;
        }
    }
}
