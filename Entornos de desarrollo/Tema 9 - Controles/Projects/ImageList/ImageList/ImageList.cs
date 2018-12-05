using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageList
{
    public partial class ImageList : Form
    {
        public ImageList()
        {
            InitializeComponent();
        }

        int i = -1;

        private void btNext_Click(object sender, EventArgs e)
        {
            if (i >= imageList1.Images.Count - 1)
                i = 0;
            else
                i++;
            pictureBox1.Image = imageList1.Images[i];
        }
    }
}
