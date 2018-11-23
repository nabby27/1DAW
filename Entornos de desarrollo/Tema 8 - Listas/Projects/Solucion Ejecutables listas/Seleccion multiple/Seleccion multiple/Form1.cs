using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seleccion_multiple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addItems();
        }

        public void addItems()
        {
            lbItems.Items.Add("Dilluns");
            lbItems.Items.Add("Dimarts");
            lbItems.Items.Add("Dimecres");
            lbItems.Items.Add("Dojous");
            lbItems.Items.Add("Divendres");
            lbItems.Items.Add("Dissabte");
            lbItems.Items.Add("Diumenge");
        }

        private void changeItemsSelected(object sender, EventArgs e)
        {
            lSeleccionado.Text = lbItems.SelectedItems.Count.ToString();
        }

        private void showSelectedItems(object sender, EventArgs e)
        {
            tbItemsSelected.Clear();
            foreach(Object item in lbItems.SelectedItems) {
                tbItemsSelected.AppendText(item.ToString() + '\n');
            }
        }

        private void remove(object sender, EventArgs e)
        {
            lbItems.SelectedItems.Remove(lbItems.SelectedItems);
            if (lbItems.Items.Count > 0)
                lbItems.Items.RemoveAt(0);
        }

    }
}
