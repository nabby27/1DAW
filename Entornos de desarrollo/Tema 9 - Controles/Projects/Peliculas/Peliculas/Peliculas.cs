using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
            addItems();
        }

        public void addItems()
        {
            cbPeliculas.Items.Add("Kill Bill");
            cbPeliculas.Items.Add("Django");
            cbPeliculas.Items.Add("Abierto hasta el amanacer");
        }
    }
}
