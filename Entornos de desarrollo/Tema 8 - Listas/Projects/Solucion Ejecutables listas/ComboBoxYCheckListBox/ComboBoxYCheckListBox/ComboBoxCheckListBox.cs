using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxYCheckListBox
{
    public partial class ComboBoxCheckListBox : Form
    {
        public ComboBoxCheckListBox()
        {
            InitializeComponent();
            addItems();
        }

        public void addItems()
        {
            cmbItems.Items.Add("Dilluns");
            cmbItems.Items.Add("Dimarts");
            cmbItems.Items.Add("Dimecres");
            cmbItems.Items.Add("Dijous");
            cmbItems.Items.Add("Divendres");
            cmbItems.Items.Add("Dissabte");
            cmbItems.Items.Add("Diumenge");

            clbItems.Items.Add("Dilluns");
            clbItems.Items.Add("Dimarts");
            clbItems.Items.Add("Dimecres");
            clbItems.Items.Add("Dijous");
            clbItems.Items.Add("Divendres");
            clbItems.Items.Add("Dissabte");
            clbItems.Items.Add("Diumenge");
        }

        private void btRemoveFirstElement_Click(object sender, EventArgs e)
        {
            lIndexItem.Text = "";
            if (cmbItems.Items.Count > 0)
                cmbItems.Items.RemoveAt(0);
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lIndexItem.Text = cmbItems.SelectedIndex.ToString();
        }

        private void btSelectedElement_Click(object sender, EventArgs e)
        {
            lbItemsSelected.Items.Clear();
            foreach (String item in clbItems.CheckedItems)
            {
                lbItemsSelected.Items.Add(item.ToString());
            }
        }

        private void btRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            lIndexItem.Text = "";
            cmbItems.Items.RemoveAt(cmbItems.SelectedIndex);
        }
    }
}
