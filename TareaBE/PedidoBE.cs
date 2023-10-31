using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBE
{
    public class PedidoBE
    {
        public int id_pedido { get; set; }
        public int id_distrito { get; set; }
        public DateTime fecha { get; set; }
        public string nombre_cliente { get; set; }
        public int monto_pedido { get; set; }
    }
}
