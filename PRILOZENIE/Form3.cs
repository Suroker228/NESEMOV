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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.lada.ru/test-drive";
            System.Diagnostics.Process.Start(url);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.Show();
            this.Hide();
        }
    }
}
