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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string url = "https://www.lada.ru/cars/available/475176";
            System.Diagnostics.Process.Start(url);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.lada.ru/cars/available/443641";
            System.Diagnostics.Process.Start(url);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://www.lada.ru/cars/available/394431";
            System.Diagnostics.Process.Start(url);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
