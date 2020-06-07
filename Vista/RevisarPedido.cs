using FlujoVenta.Controlador;
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
    public partial class RevisarPedido : Form
    {
        //instanciamos boleta para obtener los valores
        Boleta revisarBoleta = new Boleta();
        public RevisarPedido()
        {
            InitializeComponent();
            //el label en propiedad de  texto sera igual a tipo pizza
            lblTipoPizzaRevisar.Text = revisarBoleta.Tipopizza.ToString();
        }
    }
}
