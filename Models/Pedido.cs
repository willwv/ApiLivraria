using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public decimal Valor { get; set; }
    }
}
