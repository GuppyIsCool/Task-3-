using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5 newForm = new Form5();
            newForm.Show();
            this.Hide();
        }
    }
}
