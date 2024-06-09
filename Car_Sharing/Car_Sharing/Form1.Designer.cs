namespace Car_Sharing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carSharingDbDataSet = new Car_Sharing.CarSharingDbDataSet();
            this.carsTableAdapter = new Car_Sharing.CarSharingDbDataSetTableAdapters.CarsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rental_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add_car = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1384, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button_add_car);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1376, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автомобили";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1376, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиенты";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1376, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Договоры";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carSharingDbDataSet;
            // 
            // carSharingDbDataSet
            // 
            this.carSharingDbDataSet.DataSetName = "CarSharingDbDataSet";
            this.carSharingDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_car,
            this.brand,
            this.type,
            this.rental_price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1370, 361);
            this.dataGridView1.TabIndex = 1;
            // 
            // id_car
            // 
            this.id_car.HeaderText = "Column1";
            this.id_car.Name = "id_car";
            this.id_car.Visible = false;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brand.HeaderText = "Марка";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rental_price
            // 
            this.rental_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rental_price.HeaderText = "Цена, руб/день";
            this.rental_price.Name = "rental_price";
            this.rental_price.ReadOnly = true;
            this.rental_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button_add_car
            // 
            this.button_add_car.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_car.Location = new System.Drawing.Point(8, 6);
            this.button_add_car.Name = "button_add_car";
            this.button_add_car.Size = new System.Drawing.Size(50, 50);
            this.button_add_car.TabIndex = 2;
            this.button_add_car.Text = "+";
            this.button_add_car.UseVisualStyleBackColor = true;
            this.button_add_car.Click += new System.EventHandler(this.button_add_car_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(64, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1189, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_customer,
            this.first_name,
            this.last_name,
            this.middle_name,
            this.address,
            this.phone_number});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1370, 361);
            this.dataGridView2.TabIndex = 1;
            // 
            // id_customer
            // 
            this.id_customer.HeaderText = "Column1";
            this.id_customer.Name = "id_customer";
            this.id_customer.Visible = false;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.HeaderText = "Имя";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_name.HeaderText = "Фамилия";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // middle_name
            // 
            this.middle_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.middle_name.HeaderText = "Отчество";
            this.middle_name.Name = "middle_name";
            this.middle_name.ReadOnly = true;
            this.middle_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // phone_number
            // 
            this.phone_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone_number.HeaderText = "Телефон номера";
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1189, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(64, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(8, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.first,
            this.last,
            this.number,
            this.car_brand,
            this.date1,
            this.date2,
            this.cost});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(3, 62);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1370, 361);
            this.dataGridView3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(1189, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 50);
            this.button6.TabIndex = 10;
            this.button6.Text = "Редактировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(64, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(8, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // first
            // 
            this.first.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first.HeaderText = "Имя";
            this.first.Name = "first";
            this.first.ReadOnly = true;
            // 
            // last
            // 
            this.last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last.HeaderText = "Фамилия";
            this.last.Name = "last";
            this.last.ReadOnly = true;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.HeaderText = "Номер телефона";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // car_brand
            // 
            this.car_brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.car_brand.HeaderText = "Марка автомобиля";
            this.car_brand.Name = "car_brand";
            this.car_brand.ReadOnly = true;
            // 
            // date1
            // 
            this.date1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date1.HeaderText = "Дата выдачи";
            this.date1.Name = "date1";
            this.date1.ReadOnly = true;
            // 
            // date2
            // 
            this.date2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date2.HeaderText = "Дата возврата";
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost.HeaderText = "Стоимость аренды, руб.";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 461);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1400, 500);
            this.MinimumSize = new System.Drawing.Size(1400, 500);
            this.Name = "Form1";
            this.Text = "Car Sharing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private CarSharingDbDataSet carSharingDbDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarSharingDbDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn rental_price;
        private System.Windows.Forms.Button button_add_car;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn first;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}

