using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int pix;
        Boolean isDown;
        Bitmap B;
        Graphics G ;
        public Form1()
        {
            InitializeComponent();
            B = new Bitmap(400, 300);
            pictureBox1.Image = B;
            G = Graphics.FromImage(B);
            isDown = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            Brush BB = new SolidBrush(label1.BackColor);
            if (isDown) {
                if (radioButton1.Checked == true) {
                    
                    G.FillRectangle(BB, e.X, e.Y, pix, pix);
                    
                }

                if (radioButton2.Checked == true) {
                    G.FillEllipse(BB, e.X, e.Y, pix, pix);
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pix = trackBar1.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                label1.BackColor = colorDialog1.Color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"U:\E5\C#\test.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                
        }
    }
}
