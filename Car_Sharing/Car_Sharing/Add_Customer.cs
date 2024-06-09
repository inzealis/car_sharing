using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Sharing
{
    public partial class Add_Customer : Form
    {
        public string first_name = null;
        public string last_name = null;
        public string middle_name = null;
        public string address = null;
        public string phone_number = null;

        public Add_Customer()
        {
            InitializeComponent();
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {
            textBox1.Text = first_name;
            textBox2.Text = last_name;
            textBox3.Text = middle_name;
            textBox4.Text = address;
            textBox5.Text = phone_number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first_name = textBox1.Text;
            last_name = textBox2.Text;
            middle_name = textBox3.Text;
            address = textBox4.Text;
            phone_number = textBox5.Text;
            Close();
        }
    }
}
