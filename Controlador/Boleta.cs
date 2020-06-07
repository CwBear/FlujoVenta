using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlujoVenta.Controlador
{
    class Boleta
    {
        string _tipopizza, _tamanopizza, _agregado1, _agregado2, _tipobebida, 
            _tamanobebida, _tipoorden;
        ArrayList infoPedido;

        public Boleta()
        {
            infoPedido = new ArrayList();
        }

        public ArrayList InfoPedidos
        {
            get { return infoPedido; }
        }

        public void addPedido(Boleta nPedido)
        {
            infoPedido.Add(nPedido);
        }

        public Boleta(string tipopizza, string tamanopizza, string agregado1, string agregado2, string tipobebida, string tamanobebida, string tipoorden)
        {
            _tipopizza = tipopizza;
            _tamanopizza = tamanopizza;
            _agregado1 = agregado1;
            _agregado2 = agregado2;
            _tipobebida = tipobebida;
            _tamanobebida = tamanobebida;
            _tipoorden = tipoorden;
        }

        public string Tipopizza { get => _tipopizza; set => _tipopizza = value; }
        public string Tamanopizza { get => _tamanopizza; set => _tamanopizza = value; }
        public string Agregado1 { get => _agregado1; set => _agregado1 = value; }
        public string Agregado2 { get => _agregado2; set => _agregado2 = value; }
        public string Tipobebida { get => _tipobebida; set => _tipobebida = value; }
        public string Tamanobebida { get => _tamanobebida; set => _tamanobebida = value; }
        public string Tipoorden { get => _tipoorden; set => _tipoorden = value; }
    }
}
