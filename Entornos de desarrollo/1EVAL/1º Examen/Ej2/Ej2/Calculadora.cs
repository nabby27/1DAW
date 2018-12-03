using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text.Equals("") || tbOpe.Text.Equals("") || tbNum2.Text.Equals(""))
            {
                MessageBox.Show("Tienes que introducir los dos números y la operación", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float num1 = float.Parse(tbNum1.Text);
                float num2 = float.Parse(tbNum2.Text);
                String operation = tbOpe.Text;
                float resultado = 0;
                switch (operation)
                {
                    case "+":
                        resultado = suma(num1, num2);
                        tbResult.Text = resultado.ToString();
                        break;
                    case "-":
                        resultado = resta(num1, num2);
                        tbResult.Text = resultado.ToString();
                        break;
                    case "*":
                        resultado = mult(num1, num2);
                        tbResult.Text = resultado.ToString();
                        break;
                    case "/":
                        resultado = div(num1, num2);
                        tbResult.Text = resultado.ToString();
                        break;
                    case "%":
                        resultado = mod(num1, num2);
                        tbResult.Text = resultado.ToString();
                        break;
                    default:
                        MessageBox.Show("La operación no es correcta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbNum1.Clear();
            tbNum2.Clear();
            tbOpe.Clear();
            tbResult.Clear();
        }

        private static float suma(float n1, float n2) {
            return n1 + n2;
        }

        private static float resta(float n1, float n2)
        {
            return n1 - n2;
        }

        private static float mult(float n1, float n2)
        {
            return n1 * n2;
        }

        private static float div(float n1, float n2)
        {
            return n1 / n2;
        }

        private static float mod(float n1, float n2)
        {
            return n1 % n2;
        }

    }
}
