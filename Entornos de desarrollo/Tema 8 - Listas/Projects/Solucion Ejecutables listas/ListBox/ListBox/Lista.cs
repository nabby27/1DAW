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
            addItems();
        }

        private void addItems()
        {
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
            lbItems.ClearSelected();
            if (lbItems.Items.Count > 0)
                lbItems.Items.RemoveAt(0);
            lIndexItems.Text = "";
            lNumItems.Text = lbItems.Items.Count.ToString();
            lElements.Text = "";
        }

        private void changeSelected(object sender, EventArgs e)
        {
            if (null != lbItems.SelectedItem)
            {
                lIndexItems.Text = lbItems.SelectedIndex.ToString();
                lNumItems.Text = lbItems.Items.Count.ToString();
                lElements.Text = lbItems.SelectedItem.ToString();
            }
        }

        private void reset(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            addItems();
            lIndexItems.Text = "";
            lNumItems.Text = "";
            lElements.Text = "";
        }
    }



}
