using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JuegoTablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numTabla;
        int numRandom;
        int acierto = 0;

        private void play(object sender, EventArgs e)
        {
            if (tbNum.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (btPlay.Text == "Jugar")
                {
                    numTabla = Int32.Parse(tbNum.Text);
                    lable2.Visible = true;
                    lResultado.Visible = true;
                }
                else
                {
                    int result = Int32.Parse(tbNum.Text);
                    if (numTabla * numRandom == result)
                    {
                        lResultado.Text = (++acierto).ToString();
                        lMsg.Text = "Acierto";
                    }
                    else 
                    {
                        lMsg.Text = "Fallo : " + numTabla + " x " + numRandom + " = " + (numTabla*numRandom);
                    }
                }
                tbNum.Clear();
                Random rnd = new Random();
                numRandom = rnd.Next(11);
                lTitle.Text = "¿Cuánto es " + numTabla + " x " + numRandom + "?";
                btPlay.Text = "Calcular";
            }
        }

        private void change(object sender, EventArgs e)
        {
            btPlay.Text = "Jugar";
            lTitle.Text = "¿Con que tabla quieres jugar?";
            lMsg.Text = "";
        }

        private void reset(object sender, EventArgs e)
        {
            btPlay.Text = "Jugar";
            lTitle.Text = "¿Con que tabla quieres jugar?";
            lMsg.Text = "";
            acierto = 0;
            lResultado.Text = "";
            lResultado.Visible = false;
            lable2.Visible = false;
        }
    }
}
