using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlujoVenta
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void iniciarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarCaja nuevacaja = new IniciarCaja();
            nuevacaja.Show();
            this.Hide();
        }

        private void ingresarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoPedido nuevoPedido = new IngresoPedido();
            nuevoPedido.Show();
            this.Hide();
        }

        private void revisarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevisarPedido nuevaRevision = new RevisarPedido();
            nuevaRevision.Show();
            this.Hide();
        }
    }
}
