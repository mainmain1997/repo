using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lb7
{
    public partial class Form1 : Form
    {
        public Form4 ww = new Form4();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 gg = new Form3();
            gg.ShowDialog();
            this.textBox2.Text = gg.Car;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            if (ff.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = ff.EmployeeName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ww.Save(textBox1.Text, textBox2.Text, DateTime.Today);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ww.Show();
        }
    }
}
