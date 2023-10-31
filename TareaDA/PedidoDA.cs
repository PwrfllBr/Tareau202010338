using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaEF;

namespace TareaDA
{
    public class PedidoDA
    {
        private readonly dbTareaAADEntities db;
        public PedidoDA()
        {
            db = new dbTareaAADEntities();
        }

        public int Registrar(Pedido objPedido)
        {
            db.Pedidoes.Add(objPedido);
            db.SaveChanges();

            return objPedido.id_pedido;
        }
    }
}
