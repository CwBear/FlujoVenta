using FlujoVenta.Controlador;
using System;
using System.Collections;
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
    public partial class IngresoPedido : Form
    {
        string ntelefono, nNombrecliente, ntipopizza, ntamanopizza, nagregado1, nagregado2, ntipobebida, ntamanobebida, ntipoorden;
        Boleta nuevoPedido;

        Boleta boleta1 = new Boleta();

        public IngresoPedido()
        {
            InitializeComponent();
        }

        private Boleta Pedidonuevo()
        {
            nNombrecliente = txtNombreCliente.Text;
            ntelefono = txtTelefonoCliente.Text;
            ntipopizza = cmbTipoPizza.SelectedItem.ToString();
            ntamanopizza = cmbTamanoPizza.SelectedItem.ToString();
            nagregado1 = cmbAgregado1.SelectedItem.ToString();
            nagregado2 = cmbAgregado2.SelectedItem.ToString();
            ntipobebida = cmbTipoBebida.SelectedItem.ToString();
            ntamanobebida = cmbTamanoBebida.SelectedItem.ToString();
            ntipoorden = cmbTipoPedido.SelectedItem.ToString();

            nuevoPedido = new Boleta(ntipopizza, ntamanopizza, nagregado1, nagregado2, ntipobebida, ntamanobebida, ntipoorden);

            return nuevoPedido;
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            nNombrecliente = txtNombreCliente.Text;
        }

        private void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            ntelefono = txtTelefonoCliente.Text;
        }

        private void cmbTipoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            ntipopizza = cmbTipoPizza.SelectedItem.ToString();
        }


        private void cmbTamanoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            ntamanopizza = cmbTamanoPizza.SelectedItem.ToString();
        }

        private void cmbAgregado1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nagregado1 = cmbAgregado1.SelectedItem.ToString();
        }

        private void cmbAgregado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nagregado2 = cmbAgregado2.SelectedItem.ToString();
        }

        private void cmbTipoBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            ntipobebida = cmbTipoBebida.SelectedItem.ToString();
        }

        private void cmbTamanoBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            ntamanobebida = cmbTamanoBebida.SelectedItem.ToString();
        }

        private void cmbTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            ntipoorden = cmbTipoPedido.SelectedItem.ToString();
        }

        //Botones Ingreso Pedido
        private void btnIngresarPedido_Click(object sender, EventArgs e)
        {
            Boleta boleta2 = Pedidonuevo();
            boleta1.addPedido(nuevoPedido);
            MessageBox.Show("Pedido Ingresado");
        }

        private void btnLimpiarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Menu volverIngreso = new Menu();
            volverIngreso.Show();
            this.Hide();
        }


    }
}
