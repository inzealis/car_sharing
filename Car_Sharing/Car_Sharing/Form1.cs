using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Car_Sharing
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Dictionary<string, int> GetCustomersDict()
        {
            SqlDataReader dataReader1 = null;

            Dictionary<string, int> customers = new Dictionary<string, int>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT id, first_name, last_name FROM Customers", sqlConnection);
                dataReader1 = sqlCommand.ExecuteReader();

                while (dataReader1.Read())
                {
                    var id = Convert.ToInt32(dataReader1["id"]);
                    var first = Convert.ToString(dataReader1["first_name"]);
                    var last = Convert.ToString(dataReader1["last_name"]);
                    customers.Add(first + ' ' +  last, id);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader1 != null && !dataReader1.IsClosed)
                    dataReader1.Close();
            }

            return customers;
        }

        public Dictionary<string, int> GetCarsDict()
        {
            SqlDataReader dataReader = null;
            Dictionary<string, int> cars = new Dictionary<string, int>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT id, brand FROM Cars", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    var id = Convert.ToInt32(dataReader["id"]);
                    var brand = Convert.ToString(dataReader["brand"]);
                    cars.Add(brand, id);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }

            return cars;
        }

        public void UpdateCar()
        {
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT id, brand, type, rental_price FROM Cars", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    var id = Convert.ToInt32(dataReader["id"]);
                    var brand = Convert.ToString(dataReader["brand"]);
                    var type = Convert.ToString(dataReader["type"]);
                    var price = Convert.ToDouble(dataReader["rental_price"]);
                    dataGridView1.Rows.Add(id, brand, type, price);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }

        public void UpdateCustomer()
        {
            SqlDataReader dataReader1 = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT id, first_name, last_name, middle_name, address, phone_number FROM Customers", sqlConnection);
                dataReader1 = sqlCommand.ExecuteReader();

                while (dataReader1.Read())
                {
                    var id = Convert.ToInt32(dataReader1["id"]);
                    var first = Convert.ToString(dataReader1["first_name"]);
                    var last = Convert.ToString(dataReader1["last_name"]);
                    var middle = Convert.ToString(dataReader1["middle_name"]);
                    var address = Convert.ToString(dataReader1["address"]);
                    var phone_number = Convert.ToString(dataReader1["phone_number"]);
                    dataGridView2.Rows.Add(id, first, last, middle, address, phone_number);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader1 != null && !dataReader1.IsClosed)
                    dataReader1.Close();
            }
        }

        public void UpdateContract()
        {
            SqlDataReader dataReader2 = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT id, id_customer, id_car, date_of_issue, date_of_return FROM Contracts", sqlConnection);
                dataReader2 = sqlCommand.ExecuteReader();

                List<int> customers = new List<int>();
                List<int> cars = new List<int>();

                while (dataReader2.Read())
                {
                    string first = "", last = "", phone_number = "", brand = "";
                    double rental_price;
                    var id = Convert.ToInt32(dataReader2["id"]);
                    var id_customer = Convert.ToInt32(dataReader2["id_customer"]);
                    var id_car = Convert.ToInt32(dataReader2["id_car"]);
                    var date1 = Convert.ToString(dataReader2["date_of_issue"]).Substring(0, 10);
                    var date2 = Convert.ToString(dataReader2["date_of_return"]).Substring(0, 10);

                    List<string> res = GetCellValueByID(id_customer);
                    first = res[0];
                    last = res[1];
                    phone_number = res[2];

                    List<string> res2 = GetCellValueByID_Car(id_car);
                    brand = res2[0];
                    rental_price = Convert.ToDouble(res2[1]) * Convert.ToDouble(DaysCounter(date1, date2));

                    dataGridView3.Rows.Add(id, first, last, phone_number, brand, date1, date2, rental_price);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader2 != null && !dataReader2.IsClosed)
                    dataReader2.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        List<string> GetCellValueByID(int id)
        {
            List<string> result = new List<string>();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToInt32(row.Cells["id_customer"].Value) == id) // Предположим, что у колонки с ID установлено имя "ID"
                {
                    result.Add(row.Cells["first_name"].Value.ToString());
                    result.Add(row.Cells["last_name"].Value.ToString());
                    result.Add(row.Cells["phone_number"].Value.ToString());

                    return result; // Получение значения ячейки Name
                }
            }

            return null; // Возвращаем null, если не нашли нужную строку
        }

        List<string> GetCellValueByID_Car(int id)
        {
            List<string> result = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells["id_car"].Value) == id) // Предположим, что у колонки с ID установлено имя "ID"
                {
                    result.Add(row.Cells["brand"].Value.ToString());
                    result.Add(row.Cells["rental_price"].Value.ToString());

                    return result; // Получение значения ячейки Name
                }
            }

            return null; // Возвращаем null, если не нашли нужную строку
        }

        public int DaysCounter(string d1, string d2)
        {
            DateTime date1 = DateTime.ParseExact(d1, "dd.MM.yyyy", null);
            DateTime date2 = DateTime.ParseExact(d2, "dd.MM.yyyy", null);

            TimeSpan difference = date2 - date1;
            int differenceInDays = difference.Days;
            return differenceInDays;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carSharingDbDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.carSharingDbDataSet.Cars);
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarSharingDB"].ConnectionString);

                sqlConnection.Open();

                //if (sqlConnection.State == ConnectionState.Open)
                    //MessageBox.Show("Подключение установлено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            UpdateCar();
            UpdateCustomer();
            UpdateContract();
        }

        private void button_add_car_Click_1(object sender, EventArgs e)
        {
            Add_Car add_Car = new Add_Car();
            add_Car.ShowDialog();
            if (add_Car.brand != null)
            {
                SqlCommand command = new SqlCommand($"INSERT INTO [Cars] (brand, type, rental_price) VALUES (@brand, @type, @rental_price)", sqlConnection);

                command.Parameters.AddWithValue("brand", add_Car.brand);
                command.Parameters.AddWithValue("type", add_Car.type);
                command.Parameters.AddWithValue("rental_price", Convert.ToDouble(add_Car.price));
                command.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                UpdateCar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            SqlCommand command = new SqlCommand($"DELETE FROM Cars WHERE id = '{n}'", sqlConnection);
            command.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            UpdateCar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Add_Car add_Car = new Add_Car();
            add_Car.brand = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            add_Car.type = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            add_Car.price = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            add_Car.ShowDialog();
            if (add_Car.brand != null)
            {
                SqlCommand command = new SqlCommand($"UPDATE [Cars] SET brand = N'{add_Car.brand}', type = N'{add_Car.type}', rental_price = '{add_Car.price}' WHERE id = '{n}'", sqlConnection);
                command.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                UpdateCar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Customer add_Customer = new Add_Customer();
            add_Customer.ShowDialog();
            if (add_Customer.first_name != null)
            {
                SqlCommand command = new SqlCommand($"INSERT INTO [Customers] (first_name, last_name, middle_name, address, phone_number) VALUES (@first_name, @last_name, @middle_name, @address, @phone_number)", sqlConnection);

                command.Parameters.AddWithValue("first_name", add_Customer.first_name);
                command.Parameters.AddWithValue("last_name", add_Customer.last_name);
                command.Parameters.AddWithValue("middle_name", add_Customer.middle_name);
                command.Parameters.AddWithValue("address", add_Customer.address);
                command.Parameters.AddWithValue("phone_number", add_Customer.phone_number);
                command.ExecuteNonQuery();
                dataGridView2.Rows.Clear();
                UpdateCustomer();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            SqlCommand command = new SqlCommand($"DELETE FROM Customers WHERE id = '{n}'", sqlConnection);
            command.ExecuteNonQuery();
            dataGridView2.Rows.Clear();
            UpdateCustomer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            Add_Customer add_Customer = new Add_Customer();

            add_Customer.first_name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            add_Customer.last_name = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            add_Customer.middle_name = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            add_Customer.address = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            add_Customer.phone_number = dataGridView2.CurrentRow.Cells[5].Value.ToString();

            add_Customer.ShowDialog();

            if (add_Customer.first_name != null)
            {
                SqlCommand command = new SqlCommand($"UPDATE [Customers] SET first_name = N'{add_Customer.first_name}', last_name = N'{add_Customer.last_name}', middle_name = N'{add_Customer.middle_name}', address = N'{add_Customer.address}', phone_number = '{add_Customer.phone_number}' WHERE id = '{n}'", sqlConnection);
                command.ExecuteNonQuery();
                dataGridView2.Rows.Clear();
                UpdateCustomer();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            SqlCommand command = new SqlCommand($"DELETE FROM Contracts WHERE id = '{n}'", sqlConnection);
            command.ExecuteNonQuery();
            dataGridView3.Rows.Clear();
            UpdateContract();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_Contract add_Contract = new Add_Contract();
            add_Contract.customers = GetCustomersDict();
            add_Contract.cars = GetCarsDict();
            add_Contract.ShowDialog();

            if (add_Contract.id_customer != -1)
            {
                SqlCommand command = new SqlCommand($"INSERT INTO [Contracts] (id_customer, id_car, date_of_issue, date_of_return) VALUES (@id_customer, @id_car, @date_of_issue, @date_of_return)", sqlConnection);

                command.Parameters.AddWithValue("id_customer", add_Contract.id_customer);
                command.Parameters.AddWithValue("id_car", add_Contract.id_car);
                command.Parameters.AddWithValue("date_of_issue", add_Contract.date1);
                command.Parameters.AddWithValue("date_of_return", add_Contract.date2);
                command.ExecuteNonQuery();
                dataGridView3.Rows.Clear();
                UpdateContract();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            Add_Contract add_Contract = new Add_Contract();

            add_Contract.customers = GetCustomersDict();
            add_Contract.cars = GetCarsDict();
            add_Contract.name = dataGridView3.CurrentRow.Cells[1].Value.ToString() + ' ' + dataGridView3.CurrentRow.Cells[2].Value.ToString();
            add_Contract.car = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            add_Contract.date1 = DateTime.ParseExact(dataGridView3.CurrentRow.Cells[5].Value.ToString(), "dd.MM.yyyy", null);
            add_Contract.date2 = DateTime.ParseExact(dataGridView3.CurrentRow.Cells[6].Value.ToString(), "dd.MM.yyyy", null);

            add_Contract.ShowDialog();

            if (add_Contract.id_customer != -1)
            {
                string d1 = add_Contract.date1.ToString("yyyy-MM-dd");
                string d2 = add_Contract.date2.ToString("yyyy-MM-dd");
                SqlCommand command = new SqlCommand($"UPDATE [Contracts] SET id_customer = N'{add_Contract.id_customer}', id_car = N'{add_Contract.id_car}', date_of_issue = '{d1}', date_of_return = '{d2}' WHERE id = '{n}'", sqlConnection);
                command.ExecuteNonQuery();
                dataGridView3.Rows.Clear();
                UpdateContract();
            }
        }
    }
}
