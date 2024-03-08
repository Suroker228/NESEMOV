using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRILOZENIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }   

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }
    }
}
