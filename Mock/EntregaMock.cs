using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Mock
{
    public static class EntregaMock
    {
        public static List<Entrega> EntregasMockadas() {
            List<Entrega> entregas = new List<Entrega>();

            entregas.Add(new Entrega() {
                Id = 0,
                IdCliente = 1,
                Local = "Rua Santa Efigênia",
                Status = "Pendente"
            });

            entregas.Add(new Entrega()
            {
                Id = 1,
                IdCliente = 2,
                Local = "casa do cliente",
                Status = "entregue"
            });

            entregas.Add(new Entrega()
            {
                Id = 2,
                IdCliente = 3,
                Local = "Endereço do vendedor",
                Status = "atrasado"
            });

            return entregas;
        }
    }
}
