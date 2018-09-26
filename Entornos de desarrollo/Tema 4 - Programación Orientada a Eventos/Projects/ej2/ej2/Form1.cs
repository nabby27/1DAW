using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            moveX.Text = System.Convert.ToString(e.X);
            moveY.Text = System.Convert.ToString(e.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            downX.Text = System.Convert.ToString(e.X);
            downY.Text = System.Convert.ToString(e.Y);
            mouseBoton.Text = e.Button.ToString();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp.Text = "Soltado";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mouseClick.Text = "Ejecutado";
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mouseDobleClick.Text = "Ejecutado";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            mouseHover.Text = "Ejecutado";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            tecla.Text = e.KeyCode.ToString();

            switch (tecla.Text) {
                case "Menu":

                    break;
                case "Alt":

                    break;
            }
                

            if (tecla.Text == "F10")
                groupBox5.Enabled = true;
            if (tecla.Text == "F11")
                groupBox4.Enabled = true;
        }

    }
}
