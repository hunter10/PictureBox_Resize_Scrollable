using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_Resize_Scrollable
{
    public partial class Form1 : Form
    {
        Image imgOriginal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    imgOriginal = pictureBox1.Image;

                    int nImgW = pictureBox1.Image.Width;
                    int nImgH = pictureBox1.Image.Height;

                    pictureBox1.Width = nImgW;
                    pictureBox1.Height = nImgH;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Dispose();
        }
    }
}
