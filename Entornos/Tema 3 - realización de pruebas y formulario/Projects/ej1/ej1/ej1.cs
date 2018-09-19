using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ej1
{
    static class ej1
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
