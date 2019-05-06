using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO
{
    class Cuenta
    {
        public string nombre { get; set; }
        public string cuenta { get; set; }
        public double saldo { get; set; }
        public double tipoDeInteres { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(string nombre, string cuenta, double saldo, double tipoDeInteres)
        {
            this.nombre = nombre;
            this.cuenta = cuenta;
            this.saldo = saldo;
            this.tipoDeInteres = tipoDeInteres;
        }

    }
}
