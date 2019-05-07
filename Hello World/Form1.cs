using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello"+txtBxConnor.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point( pictureBox1.Location.X,pictureBox1.Location.Y -  10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            await Task.Delay(200);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
            await Task.Delay(200);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            await Task.Delay(200);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
            await Task.Delay(200);
        }

    }
}
