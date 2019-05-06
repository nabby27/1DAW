using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO
{
    class Empleado
    {
        public String nombre { get; set; }
        public double pagaHora { get; set; }
        public double horas { get; set; }

        public Empleado()
        {
            nombre = "";
            pagaHora = 0;
            horas = 0;
        }

        public Empleado(String nombre, double pagaHora, double horas)
        {
            this.nombre = nombre;
            this.pagaHora = pagaHora;
            this.horas = horas;
        }

    }
}
