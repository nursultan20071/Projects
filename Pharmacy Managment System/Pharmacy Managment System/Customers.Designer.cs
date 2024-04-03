namespace Pharmacy_Managment_System
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomersName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.GoSelling = new System.Windows.Forms.PictureBox();
            this.btnSelling = new System.Windows.Forms.Button();
            this.GoSellers = new System.Windows.Forms.PictureBox();
            this.btnSellers = new System.Windows.Forms.Button();
            this.GoCustomers = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.GoManufacturer = new System.Windows.Forms.PictureBox();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.GoMedichines = new System.Windows.Forms.PictureBox();
            this.btnMedichines = new System.Windows.Forms.Button();
            this.GoDashboard = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedichines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVCustomer.BackgroundColor = System.Drawing.Color.White;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.GridColor = System.Drawing.Color.Black;
            this.DGVCustomer.Location = new System.Drawing.Point(12, 247);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustomer.Size = new System.Drawing.Size(885, 371);
            this.DGVCustomer.TabIndex = 30;
            this.DGVCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(358, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Список клиента";
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Муж",
            "Жен"});
            this.txtGender.Location = new System.Drawing.Point(8, 129);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(121, 27);
            this.txtGender.TabIndex = 28;
            // 
            // txtDOB
            // 
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDOB.Location = new System.Drawing.Point(682, 56);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(150, 27);
            this.txtDOB.TabIndex = 27;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Location = new System.Drawing.Point(436, 56);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(197, 27);
            this.txtMobileNo.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(243, 54);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(158, 67);
            this.txtAddress.TabIndex = 25;
            // 
            // txtCustomersName
            // 
            this.txtCustomersName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomersName.Location = new System.Drawing.Point(6, 54);
            this.txtCustomersName.Name = "txtCustomersName";
            this.txtCustomersName.Size = new System.Drawing.Size(215, 27);
            this.txtCustomersName.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(536, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 40);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(382, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 40);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Обновлять";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(232, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(7, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Род\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(679, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = " Имя клиента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(433, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер мобильного телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(240, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Адрес\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(1, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сведения о клиентах\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(264, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Клиенты";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1133, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 42);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 40;
            this.btnClose.TabStop = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GoLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.GoSelling);
            this.panel1.Controls.Add(this.btnSelling);
            this.panel1.Controls.Add(this.GoSellers);
            this.panel1.Controls.Add(this.btnSellers);
            this.panel1.Controls.Add(this.GoCustomers);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.GoManufacturer);
            this.panel1.Controls.Add(this.btnManufacturer);
            this.panel1.Controls.Add(this.GoMedichines);
            this.panel1.Controls.Add(this.btnMedichines);
            this.panel1.Controls.Add(this.GoDashboard);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 722);
            this.panel1.TabIndex = 36;
            // 
            // GoLogout
            // 
            this.GoLogout.Image = ((System.Drawing.Image)(resources.GetObject("GoLogout.Image")));
            this.GoLogout.Location = new System.Drawing.Point(3, 663);
            this.GoLogout.Name = "GoLogout";
            this.GoLogout.Size = new System.Drawing.Size(50, 50);
            this.GoLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoLogout.TabIndex = 29;
            this.GoLogout.TabStop = false;
            this.GoLogout.Click += new System.EventHandler(this.GoLogout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.Location = new System.Drawing.Point(59, 668);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 40);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // GoSelling
            // 
            this.GoSelling.Image = ((System.Drawing.Image)(resources.GetObject("GoSelling.Image")));
            this.GoSelling.Location = new System.Drawing.Point(3, 492);
            this.GoSelling.Name = "GoSelling";
            this.GoSelling.Size = new System.Drawing.Size(50, 50);
            this.GoSelling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSelling.TabIndex = 27;
            this.GoSelling.TabStop = false;
            this.GoSelling.Click += new System.EventHandler(this.GoSelling_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelling.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSelling.Location = new System.Drawing.Point(59, 497);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(169, 40);
            this.btnSelling.TabIndex = 26;
            this.btnSelling.Text = "Продажа";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // GoSellers
            // 
            this.GoSellers.Image = ((System.Drawing.Image)(resources.GetObject("GoSellers.Image")));
            this.GoSellers.Location = new System.Drawing.Point(3, 425);
            this.GoSellers.Name = "GoSellers";
            this.GoSellers.Size = new System.Drawing.Size(50, 50);
            this.GoSellers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSellers.TabIndex = 25;
            this.GoSellers.TabStop = false;
            this.GoSellers.Click += new System.EventHandler(this.GoSellers_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.White;
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSellers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSellers.Location = new System.Drawing.Point(59, 430);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(169, 40);
            this.btnSellers.TabIndex = 24;
            this.btnSellers.Text = "Продавцы";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // GoCustomers
            // 
            this.GoCustomers.Image = ((System.Drawing.Image)(resources.GetObject("GoCustomers.Image")));
            this.GoCustomers.Location = new System.Drawing.Point(3, 362);
            this.GoCustomers.Name = "GoCustomers";
            this.GoCustomers.Size = new System.Drawing.Size(50, 50);
            this.GoCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoCustomers.TabIndex = 23;
            this.GoCustomers.TabStop = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(59, 367);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(169, 40);
            this.btnCustomers.TabIndex = 22;
            this.btnCustomers.Text = "Клиенты";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // GoManufacturer
            // 
            this.GoManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("GoManufacturer.Image")));
            this.GoManufacturer.Location = new System.Drawing.Point(3, 229);
            this.GoManufacturer.Name = "GoManufacturer";
            this.GoManufacturer.Size = new System.Drawing.Size(50, 50);
            this.GoManufacturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoManufacturer.TabIndex = 21;
            this.GoManufacturer.TabStop = false;
            this.GoManufacturer.Click += new System.EventHandler(this.GoManufacturer_Click);
            // 
            // btnManufacturer
            // 
            this.btnManufacturer.BackColor = System.Drawing.Color.White;
            this.btnManufacturer.FlatAppearance.BorderSize = 0;
            this.btnManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManufacturer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManufacturer.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManufacturer.Location = new System.Drawing.Point(59, 234);
            this.btnManufacturer.Name = "btnManufacturer";
            this.btnManufacturer.Size = new System.Drawing.Size(169, 40);
            this.btnManufacturer.TabIndex = 20;
            this.btnManufacturer.Text = "Производитель";
            this.btnManufacturer.UseVisualStyleBackColor = false;
            this.btnManufacturer.Click += new System.EventHandler(this.btnManufacturer_Click);
            // 
            // GoMedichines
            // 
            this.GoMedichines.Image = ((System.Drawing.Image)(resources.GetObject("GoMedichines.Image")));
            this.GoMedichines.Location = new System.Drawing.Point(3, 295);
            this.GoMedichines.Name = "GoMedichines";
            this.GoMedichines.Size = new System.Drawing.Size(50, 50);
            this.GoMedichines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoMedichines.TabIndex = 19;
            this.GoMedichines.TabStop = false;
            // 
            // btnMedichines
            // 
            this.btnMedichines.BackColor = System.Drawing.Color.White;
            this.btnMedichines.FlatAppearance.BorderSize = 0;
            this.btnMedichines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedichines.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedichines.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnMedichines.Location = new System.Drawing.Point(59, 300);
            this.btnMedichines.Name = "btnMedichines";
            this.btnMedichines.Size = new System.Drawing.Size(169, 40);
            this.btnMedichines.TabIndex = 18;
            this.btnMedichines.Text = "Лекарства";
            this.btnMedichines.UseVisualStyleBackColor = false;
            // 
            // GoDashboard
            // 
            this.GoDashboard.Image = ((System.Drawing.Image)(resources.GetObject("GoDashboard.Image")));
            this.GoDashboard.Location = new System.Drawing.Point(3, 163);
            this.GoDashboard.Name = "GoDashboard";
            this.GoDashboard.Size = new System.Drawing.Size(50, 50);
            this.GoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoDashboard.TabIndex = 17;
            this.GoDashboard.TabStop = false;
            this.GoDashboard.Click += new System.EventHandler(this.GoDashboard_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard.Location = new System.Drawing.Point(59, 168);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(169, 40);
            this.btnDashboard.TabIndex = 16;
            this.btnDashboard.Text = "Приборная панель";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(109, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Здравоохранение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(683, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Version 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(596, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Pharmacy Managment System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DGVCustomer);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.txtDOB);
            this.panel2.Controls.Add(this.txtMobileNo);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtCustomersName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(268, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 621);
            this.panel2.TabIndex = 37;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1176, 722);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedichines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomersName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GoLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox GoSelling;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.PictureBox GoSellers;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.PictureBox GoCustomers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox GoManufacturer;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.PictureBox GoMedichines;
        private System.Windows.Forms.Button btnMedichines;
        private System.Windows.Forms.PictureBox GoDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}