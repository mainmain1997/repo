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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void Save(string Employee, string CarName, DateTime DateCredit)
        {
            listBox1.Items.Add(Employee);
            listBox2.Items.Add(CarName);
            listBox3.Items.Add(DateCredit);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
