using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace H_Listas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new H_EjercicioListas2());
        }
    }
}
