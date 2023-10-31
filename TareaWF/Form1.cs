using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaBE;
using TareaBL;
using TareaEF;

namespace TareaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDistritos();
        }

        private void CargarDistritos()
        {
            var objDistritoBL = new DistritoBL();
            var Distrito = objDistritoBL.ListarDistritos();
            cbDistrito.Items.AddRange(Distrito.ToArray());
            cbDistrito.ValueMember = "id_distrito";
            cbDistrito.DisplayMember = "nombre_distrito";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var objPedido = new Pedido
            {
                id_distrito = ((DistritoBE)cbDistrito.SelectedItem).id_distrito,
                fecha = dtpFecha.Value,
                monto_pedido = int.Parse(txtMonto.Text),
                nombre_cliente = txtNombreCliente.Text,
            };

            var objPedidoBL = new PedidoBL();
            objPedidoBL.Registrar(objPedido);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
