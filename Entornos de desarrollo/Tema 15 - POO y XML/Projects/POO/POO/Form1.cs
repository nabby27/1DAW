using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cuenta cuenta01 = new Cuenta();
            cuenta01.nombre = "Pepe";
            cuenta01.cuenta = "1234-44-5-00000000000000079798";
            cuenta01.tipoDeInteres = 2.5;
            cuenta01.saldo = 234.89;
            Cuenta cuenta02 = new Cuenta("Luis", "1234-44-5-00000000000000869699", 6000, 3.5);
            Cuenta cuenta03 = new Cuenta { nombre = "Luis", cuenta = "1234-44-5-00000000000000869699" };

            List<Cuenta> clientes = new List<Cuenta>();

            clientes.Add(cuenta01);
            clientes.Add(cuenta02);
            clientes.Add(cuenta03);

            listBox1.Items.Add("---------foreach---------");
            foreach (Cuenta cuenta in clientes) 
            {
                listBox1.Items.Add(cuenta.nombre);
                listBox1.Items.Add(cuenta.cuenta);
                listBox1.Items.Add(cuenta.saldo);
                listBox1.Items.Add(cuenta.tipoDeInteres);
                listBox1.Items.Add("----------------------");
            }

        }

    }
}
