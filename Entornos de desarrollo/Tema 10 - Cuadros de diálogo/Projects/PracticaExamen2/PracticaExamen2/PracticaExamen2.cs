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
        int indexCurrentPicture = 0;

        public PracticaExamen2()
        {
            InitializeComponent();
            timerDate.Enabled = true;
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            statusStripsLabelDate.Text = DateTime.Now.ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            timerPictureBack.Start();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            timerPictureNext.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timerPictureNext.Stop();
            timerPictureBack.Stop();
        }

        private void timerPictureNext_Tick(object sender, EventArgs e)
        {
            for (int i = indexCurrentPicture; i <= imageList.Images.Count; i--)
            {
                pictureBox.Image = imageList.Images[i]
            }
        }

        private void timerPictureBack_Tick(object sender, EventArgs e)
        {
            for (int i = indexCurrentPicture; i >= 0; i--)
            {
                pictureBox.Image = imageList.Images[i];
            }
        }
    }
}
