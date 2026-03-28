namespace SalesForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridCustomers = new DataGridView();
            gbCustomer = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtCredit = new TextBox();
            txtCountry = new TextBox();
            txtState = new TextBox();
            txtCity = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            label4 = new Label();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            lableCname = new Label();
            label5 = new Label();
            txtCname = new TextBox();
            comboSales = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            comboCustomer = new ComboBox();
            btnInsert = new Button();
            btnCancel = new Button();
            labelComboTitle = new Label();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).BeginInit();
            gbCustomer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridCustomers
            // 
            gridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomers.GridColor = SystemColors.ScrollBar;
            gridCustomers.Location = new Point(1, 424);
            gridCustomers.Name = "gridCustomers";
            gridCustomers.RowHeadersWidth = 51;
            gridCustomers.Size = new Size(799, 82);
            gridCustomers.TabIndex = 0;
            // 
            // gbCustomer
            // 
            gbCustomer.Controls.Add(tableLayoutPanel1);
            gbCustomer.Dock = DockStyle.Top;
            gbCustomer.Location = new Point(0, 0);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Size = new Size(800, 213);
            gbCustomer.TabIndex = 6;
            gbCustomer.TabStop = false;
            gbCustomer.Text = "Customer Details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.Controls.Add(txtAddress, 3, 0);
            tableLayoutPanel1.Controls.Add(txtPhone, 1, 3);
            tableLayoutPanel1.Controls.Add(txtLname, 1, 2);
            tableLayoutPanel1.Controls.Add(txtFname, 1, 1);
            tableLayoutPanel1.Controls.Add(txtCredit, 3, 4);
            tableLayoutPanel1.Controls.Add(txtCountry, 3, 3);
            tableLayoutPanel1.Controls.Add(txtState, 3, 2);
            tableLayoutPanel1.Controls.Add(txtCity, 3, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(label11, 2, 3);
            tableLayoutPanel1.Controls.Add(label10, 2, 4);
            tableLayoutPanel1.Controls.Add(lableCname, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCname, 1, 0);
            tableLayoutPanel1.Controls.Add(comboSales, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(794, 187);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(575, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(216, 27);
            txtAddress.TabIndex = 24;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(179, 114);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(214, 27);
            txtPhone.TabIndex = 23;
            // 
            // txtLname
            // 
            txtLname.Dock = DockStyle.Fill;
            txtLname.Location = new Point(179, 77);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(214, 27);
            txtLname.TabIndex = 22;
            // 
            // txtFname
            // 
            txtFname.Dock = DockStyle.Fill;
            txtFname.Location = new Point(179, 40);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(214, 27);
            txtFname.TabIndex = 21;
            // 
            // txtCredit
            // 
            txtCredit.Dock = DockStyle.Fill;
            txtCredit.Location = new Point(575, 151);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(216, 27);
            txtCredit.TabIndex = 20;
            // 
            // txtCountry
            // 
            txtCountry.Dock = DockStyle.Fill;
            txtCountry.Location = new Point(575, 114);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(216, 27);
            txtCountry.TabIndex = 19;
            // 
            // txtState
            // 
            txtState.Dock = DockStyle.Fill;
            txtState.Location = new Point(575, 77);
            txtState.Name = "txtState";
            txtState.Size = new Size(216, 27);
            txtState.TabIndex = 18;
            // 
            // txtCity
            // 
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(575, 40);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(216, 27);
            txtCity.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 111);
            label6.Name = "label6";
            label6.Size = new Size(170, 37);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 148);
            label7.Name = "label7";
            label7.Size = new Size(170, 39);
            label7.TabIndex = 6;
            label7.Text = "Sales Rep";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(399, 37);
            label8.Name = "label8";
            label8.Size = new Size(170, 37);
            label8.TabIndex = 7;
            label8.Text = "City";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(170, 37);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(399, 74);
            label4.Name = "label4";
            label4.Size = new Size(170, 37);
            label4.TabIndex = 3;
            label4.Text = "Sate";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(399, 0);
            label9.Name = "label9";
            label9.Size = new Size(170, 37);
            label9.TabIndex = 8;
            label9.Text = "Address";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(399, 111);
            label11.Name = "label11";
            label11.Size = new Size(170, 37);
            label11.TabIndex = 10;
            label11.Text = "Country";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(399, 148);
            label10.Name = "label10";
            label10.Size = new Size(170, 39);
            label10.TabIndex = 9;
            label10.Text = "Credit Limit";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lableCname
            // 
            lableCname.AutoSize = true;
            lableCname.Dock = DockStyle.Fill;
            lableCname.Location = new Point(3, 0);
            lableCname.Name = "lableCname";
            lableCname.Size = new Size(170, 37);
            lableCname.TabIndex = 0;
            lableCname.Text = "Company Name";
            lableCname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 37);
            label5.Name = "label5";
            label5.Size = new Size(170, 37);
            label5.TabIndex = 4;
            label5.Text = "First Name";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCname
            // 
            txtCname.Dock = DockStyle.Fill;
            txtCname.Location = new Point(179, 3);
            txtCname.Name = "txtCname";
            txtCname.Size = new Size(214, 27);
            txtCname.TabIndex = 11;
            // 
            // comboSales
            // 
            comboSales.Dock = DockStyle.Fill;
            comboSales.Enabled = false;
            comboSales.FormattingEnabled = true;
            comboSales.Location = new Point(179, 151);
            comboSales.Name = "comboSales";
            comboSales.Size = new Size(214, 28);
            comboSales.TabIndex = 25;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 342);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(12, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboCustomer
            // 
            comboCustomer.FormattingEnabled = true;
            comboCustomer.Location = new Point(635, 236);
            comboCustomer.Name = "comboCustomer";
            comboCustomer.Size = new Size(151, 28);
            comboCustomer.TabIndex = 11;
            comboCustomer.Text = "Customer..";
            comboCustomer.SelectedIndexChanged += comboCustomer_SelectedIndexChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 219);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert new ";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(121, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelComboTitle
            // 
            labelComboTitle.AutoSize = true;
            labelComboTitle.Location = new Point(635, 213);
            labelComboTitle.Name = "labelComboTitle";
            labelComboTitle.Size = new Size(72, 20);
            labelComboTitle.TabIndex = 14;
            labelComboTitle.Text = "Customer";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(692, 377);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(94, 29);
            btnMenu.TabIndex = 15;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(btnMenu);
            Controls.Add(labelComboTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(comboCustomer);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(gbCustomer);
            Controls.Add(gridCustomers);
            Name = "Form1";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)gridCustomers).EndInit();
            gbCustomer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridCustomers;
        private GroupBox gbCustomer;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label5;
        private Label lableCname;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label8;
        private Label label2;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox comboCustomer;
        private TextBox txtCredit;
        private TextBox txtCountry;
        private TextBox txtState;
        private TextBox txtCity;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtCname;
        private TextBox txtPhone;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtAddress;
        private ComboBox comboSales;
        private Button btnInsert;
        private Button btnCancel;
        private Label labelComboTitle;
        private Button btnMenu;
    }
}
