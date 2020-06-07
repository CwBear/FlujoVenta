using FlujoVenta.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlujoVenta
{
    class Trabajador : Persona
    {
        string _nombreTrabajador;
        int _rutTrabajador;

        public Trabajador(string nombreTrabajador, int rutTrabajador)
        {
            _nombreTrabajador = nombreTrabajador;
            _rutTrabajador = rutTrabajador;
        }

        public string NombreTrabajador { get => _nombreTrabajador; set => _nombreTrabajador = value; }
        public int RutTrabajador { get => _rutTrabajador; set => _rutTrabajador = value; }
    }
}
