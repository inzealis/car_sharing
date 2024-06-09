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
    public partial class Add_Contract : Form
    {
        public Dictionary<string, int> customers = new Dictionary<string, int>();
        public Dictionary<string, int> cars = new Dictionary<string, int>();
        public string name = null;
        public string car = null;
        public DateTime date1 = DateTime.Now;
        public DateTime date2 = DateTime.Now;
        public int id_customer = -1;
        public int id_car = -1;

        public Add_Contract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_customer = customers[comboBox1.SelectedItem.ToString()];
            id_car = cars[comboBox2.SelectedItem.ToString()];
            date1 = dateTimePicker1.Value;
            date2 = dateTimePicker2.Value;

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Contract_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in customers) 
            {
                comboBox1.Items.Add(item.Key);
            }

            comboBox2.Items.Clear();
            foreach (var item in cars)
            {
                comboBox2.Items.Add(item.Key);
            }

            comboBox1.Text = name;
            comboBox2.Text = car;
            dateTimePicker1.Value = date1;
            dateTimePicker2.Value = date2;
        }
    }
}
