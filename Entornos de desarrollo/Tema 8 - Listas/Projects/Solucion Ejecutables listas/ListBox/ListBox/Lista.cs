using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            lbItems.Items.Add("Dilluns");
            lbItems.Items.Add("Dimarts");
            lbItems.Items.Add("Dimecres");
            lbItems.Items.Add("Dijous");
            lbItems.Items.Add("Divendres");
            lbItems.Items.Add("Dissabte");
            lbItems.Items.Add("Diumenge");
        }

        private void removeFirstItem(object sender, EventArgs e)
        {
            lbItems.Items.RemoveAt(lbItems.Items.);
        }
    }



}
