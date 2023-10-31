using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaDA;
using TareaEF;

namespace TareaBL
{
    public class PedidoBL
    {
        private readonly PedidoDA objPedidoDA;

        public PedidoBL()
        {
            objPedidoDA = new PedidoDA();
        }

        public int Registrar(Pedido objPedido)
        {
            return objPedidoDA.Registrar(objPedido);
        }
    }
}
