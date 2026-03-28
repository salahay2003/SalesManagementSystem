namespace SalesForm
{
    partial class SalesOfficeForm
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
            comboOffice = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            label6 = new Label();
            label8 = new Label();
            label2 = new Label();
            btnMenu = new Button();
            btnCancel = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            labelComboTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAddressTwo = new TextBox();
            txtAddressOne = new TextBox();
            tstState = new TextBox();
            txtTerirtory = new TextBox();
            txtPCODE = new TextBox();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            label14 = new Label();
            lableCity = new Label();
            txtCity = new TextBox();
            gbOffice = new GroupBox();
            gridOffice = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            gbOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOffice).BeginInit();
            SuspendLayout();
            // 
            // comboOffice
            // 
            comboOffice.FormattingEnabled = true;
            comboOffice.Location = new Point(637, 241);
            comboOffice.Name = "comboOffice";
            comboOffice.Size = new Size(151, 28);
            comboOffice.TabIndex = 21;
            comboOffice.Text = "Code...";
            comboOffice.SelectedIndexChanged += comboOffice_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(12, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 138);
            label6.Name = "label6";
            label6.Size = new Size(170, 49);
            label6.TabIndex = 5;
            label6.Text = "Address 2";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(399, 46);
            label8.Name = "label8";
            label8.Size = new Size(170, 46);
            label8.TabIndex = 7;
            label8.Text = "Postal Code";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 92);
            label2.Name = "label2";
            label2.Size = new Size(170, 46);
            label2.TabIndex = 1;
            label2.Text = "Address 1";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(692, 349);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(94, 29);
            btnMenu.TabIndex = 25;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(121, 349);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 219);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 22;
            btnInsert.Text = "Insert new ";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(399, 92);
            label4.Name = "label4";
            label4.Size = new Size(170, 46);
            label4.TabIndex = 3;
            label4.Text = "Teritory";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(399, 0);
            label9.Name = "label9";
            label9.Size = new Size(170, 46);
            label9.TabIndex = 8;
            label9.Text = "Country";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 46);
            label5.Name = "label5";
            label5.Size = new Size(170, 46);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelComboTitle
            // 
            labelComboTitle.AutoSize = true;
            labelComboTitle.Location = new Point(637, 216);
            labelComboTitle.Name = "labelComboTitle";
            labelComboTitle.Size = new Size(88, 20);
            labelComboTitle.TabIndex = 24;
            labelComboTitle.Text = "Office Code";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.Controls.Add(txtAddressTwo, 1, 3);
            tableLayoutPanel1.Controls.Add(txtAddressOne, 1, 2);
            tableLayoutPanel1.Controls.Add(tstState, 3, 3);
            tableLayoutPanel1.Controls.Add(txtTerirtory, 3, 2);
            tableLayoutPanel1.Controls.Add(txtPCODE, 3, 1);
            tableLayoutPanel1.Controls.Add(txtCountry, 3, 0);
            tableLayoutPanel1.Controls.Add(txtPhone, 1, 1);
            tableLayoutPanel1.Controls.Add(label14, 2, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(lableCity, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(txtCity, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(3, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(794, 187);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAddressTwo
            // 
            txtAddressTwo.Dock = DockStyle.Fill;
            txtAddressTwo.Location = new Point(179, 141);
            txtAddressTwo.Name = "txtAddressTwo";
            txtAddressTwo.Size = new Size(214, 27);
            txtAddressTwo.TabIndex = 23;
            // 
            // txtAddressOne
            // 
            txtAddressOne.Dock = DockStyle.Fill;
            txtAddressOne.Location = new Point(179, 95);
            txtAddressOne.Name = "txtAddressOne";
            txtAddressOne.Size = new Size(214, 27);
            txtAddressOne.TabIndex = 22;
            // 
            // tstState
            // 
            tstState.Dock = DockStyle.Fill;
            tstState.Location = new Point(575, 141);
            tstState.Name = "tstState";
            tstState.Size = new Size(216, 27);
            tstState.TabIndex = 21;
            // 
            // txtTerirtory
            // 
            txtTerirtory.Dock = DockStyle.Fill;
            txtTerirtory.Location = new Point(575, 95);
            txtTerirtory.Name = "txtTerirtory";
            txtTerirtory.Size = new Size(216, 27);
            txtTerirtory.TabIndex = 20;
            // 
            // txtPCODE
            // 
            txtPCODE.Dock = DockStyle.Fill;
            txtPCODE.Location = new Point(575, 49);
            txtPCODE.Name = "txtPCODE";
            txtPCODE.Size = new Size(216, 27);
            txtPCODE.TabIndex = 19;
            // 
            // txtCountry
            // 
            txtCountry.Dock = DockStyle.Fill;
            txtCountry.Location = new Point(575, 3);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(216, 27);
            txtCountry.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(179, 49);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(214, 27);
            txtPhone.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(399, 138);
            label14.Name = "label14";
            label14.Size = new Size(170, 49);
            label14.TabIndex = 13;
            label14.Text = "State";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lableCity
            // 
            lableCity.AutoSize = true;
            lableCity.Dock = DockStyle.Fill;
            lableCity.Location = new Point(3, 0);
            lableCity.Name = "lableCity";
            lableCity.Size = new Size(170, 46);
            lableCity.TabIndex = 0;
            lableCity.Text = "City";
            lableCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCity
            // 
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(179, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(214, 27);
            txtCity.TabIndex = 14;
            // 
            // gbOffice
            // 
            gbOffice.Controls.Add(tableLayoutPanel1);
            gbOffice.Dock = DockStyle.Top;
            gbOffice.Location = new Point(0, 0);
            gbOffice.Name = "gbOffice";
            gbOffice.Size = new Size(800, 213);
            gbOffice.TabIndex = 17;
            gbOffice.TabStop = false;
            gbOffice.Text = "Office Details";
            // 
            // gridOffice
            // 
            gridOffice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOffice.GridColor = SystemColors.ScrollBar;
            gridOffice.Location = new Point(1, 396);
            gridOffice.Name = "gridOffice";
            gridOffice.RowHeadersWidth = 51;
            gridOffice.Size = new Size(799, 82);
            gridOffice.TabIndex = 16;
            // 
            // SalesOfficeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboOffice);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnMenu);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(labelComboTitle);
            Controls.Add(gbOffice);
            Controls.Add(gridOffice);
            Name = "SalesOfficeForm";
            Text = "SalesOfficeForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gbOffice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOffice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboOffice;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label6;
        private Label label8;
        private Label label2;
        private Button btnMenu;
        private Button btnCancel;
        private Button btnInsert;
        private Button btnDelete;
        private Label label4;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label5;
        private Label labelComboTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lableCity;
        private GroupBox gbOffice;
        private DataGridView gridOffice;
        private TextBox tstState;
        private TextBox txtTerirtory;
        private TextBox txtPCODE;
        private TextBox txtCountry;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtPhone;
        private Label label14;
        private TextBox txtCity;
        private TextBox txtAddressTwo;
        private TextBox txtAddressOne;
    }
}