using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Status { get; set; }
        public string Local { get; set; }
    }
}
