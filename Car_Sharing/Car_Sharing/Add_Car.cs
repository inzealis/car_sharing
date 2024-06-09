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
    public partial class Add_Car : Form
    {

        public string brand = null;
        public string type = null;
        public string price = null;

        public Add_Car()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brand = textBox1.Text;
            type = comboBox1.SelectedItem.ToString();
            price = textBox2.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Car_Load(object sender, EventArgs e)
        {
            textBox1.Text = brand;
            comboBox1.Text = type;
            textBox2.Text = price;
        }
    }
}
