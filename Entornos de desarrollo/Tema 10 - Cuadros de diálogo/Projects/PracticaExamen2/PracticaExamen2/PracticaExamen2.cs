using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticaExamen2
{
    public partial class PracticaExamen2 : Form
    {
        int indexCurrentPicture;

        public PracticaExamen2()
        {
            InitializeComponent();
            timerDate.Enabled = true;
            indexCurrentPicture = 0;
            btStop.Enabled = false;
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            statusStripsLabelDate.Text = DateTime.Now.ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            timerPictureBack.Start();
            btStop.Enabled = true;
            btNext.Enabled = false;
            btBack.Enabled = false;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            timerPictureNext.Start();
            btStop.Enabled = true;
            btNext.Enabled = false;
            btBack.Enabled = false;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timerPictureNext.Stop();
            timerPictureBack.Stop();
            btNext.Enabled = true;
            btBack.Enabled = true;
        }

        private void timerPictureNext_Tick(object sender, EventArgs e)
        {
            if (indexCurrentPicture < imageList.Images.Count)
            {
                pictureBox.Image = imageList.Images[indexCurrentPicture];
                listBox.Items.Add((indexCurrentPicture + 1).ToString());
                indexCurrentPicture++;
            }
            else
            {
                timerPictureNext.Stop();
                btNext.Enabled = true;
                btBack.Enabled = true;
            }
        }

        private void timerPictureBack_Tick(object sender, EventArgs e)
        {
            if (indexCurrentPicture > 0)
            {
                indexCurrentPicture--;
                pictureBox.Image = imageList.Images[indexCurrentPicture];
                listBox.Items.Add((indexCurrentPicture + 1).ToString());
            }
            else
            {
                timerPictureBack.Stop();
                btNext.Enabled = true;
                btBack.Enabled = true;
            }
        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
