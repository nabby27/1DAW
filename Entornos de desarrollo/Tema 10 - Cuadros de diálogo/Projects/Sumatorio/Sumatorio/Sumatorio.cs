using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sumatorio
{
    public partial class Sumatorio : Form
    {
        int contNums;
        int sum;
        int countStart;

        public Sumatorio()
        {
            InitializeComponent();
            lStart.Visible = false;
            lStart.Text = "Iniciando en";
            lTotal.Visible = false;
            lTotal.Text = "Total: ";
            lNums.Visible = false;
            lNums.Text = "Números introducidos:";
            contNums = 0;
            sum = 0;
            countStart = 3;
        }

        private void tbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (tbNum.Text == null || tbNum.Text == "")
                {
                    MessageBox.Show("Introduce un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    contNums++;
                    int num = Int32.Parse(tbNum.Text);
                    lbNums.Items.Add(num);
                    lNums.Visible = true;
                    lNums.Text = "Números introducidos: " + contNums;
                    tbNum.Clear();
                }
            }
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            sum = 0;
            timerStart.Interval = 1;
            lTotal.Visible = false;
            timerStart.Start();
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            if (countStart == 0)
            {
                timerStart.Stop();
                lStart.Visible = false;
                timerSum.Start();
                countStart = 3;
            }
            else
            {
                lStart.Visible = true;
                lStart.Text = "Iniciando en " + countStart + " ...";
                countStart--;
                timerStart.Interval = 1000;
            }
        }

        private void timerSum_Tick(object sender, EventArgs e)
        {
            if (lbNums.Items.Count > 0)
            {
                int number = Int32.Parse(lbNums.GetItemText(lbNums.Items[0]));
                lbNums.Items.RemoveAt(0);
                sum += number;
                lTotal.Visible = true;
                lTotal.Text = "Total: " + sum;
                contNums--;
                lNums.Text = "Números introducidos: " + contNums;
            }
            else
            {
                timerSum.Stop();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            lStart.Visible = false;
            lStart.Text = "Iniciando en";
            lTotal.Visible = false;
            lTotal.Text = "Total: ";
            lNums.Visible = false;
            lNums.Text = "Números introducidos:";
            contNums = 0;
            sum = 0;
            countStart = 3;
            lbNums.Items.Clear();
        }
    }
}
