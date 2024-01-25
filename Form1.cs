using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Show the open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the picture
            pictureBox1.Image = null;

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Show the colour dialog box. If the user clicks OK, chnage the
            //PictureBox controls's backgroud to the colour the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box,
            // chnage the PictureBox's
            // SizeMode property to "Stretch". If the user clears
            // the check box, canghe it to "Normal".
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }

        }
    }
}
