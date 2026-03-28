namespace SalesForm
{
    partial class EmployeeForm
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
            comboEmp = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtExtension = new TextBox();
            txtLname = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label2 = new Label();
            btnMenu = new Button();
            btnCancel = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            label9 = new Label();
            txtFname = new TextBox();
            labelComboTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtJob = new TextBox();
            label4 = new Label();
            comboOffice = new ComboBox();
            comboRep = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            gbEmployee = new GroupBox();
            gridEmp = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            gbEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEmp).BeginInit();
            SuspendLayout();
            // 
            // comboEmp
            // 
            comboEmp.FormattingEnabled = true;
            comboEmp.Location = new Point(635, 237);
            comboEmp.Name = "comboEmp";
            comboEmp.Size = new Size(151, 28);
            comboEmp.TabIndex = 21;
            comboEmp.Text = "Employee...";
            comboEmp.SelectedIndexChanged += comboEmp_SelectedIndexChanged;
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
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(179, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 23;
            // 
            // txtExtension
            // 
            txtExtension.Dock = DockStyle.Fill;
            txtExtension.Location = new Point(179, 95);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(214, 27);
            txtExtension.TabIndex = 22;
            // 
            // txtLname
            // 
            txtLname.Dock = DockStyle.Fill;
            txtLname.Location = new Point(179, 49);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(214, 27);
            txtLname.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 138);
            label6.Name = "label6";
            label6.Size = new Size(170, 49);
            label6.TabIndex = 5;
            label6.Text = "Email";
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
            label8.Text = "Office Code";
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
            label2.Text = "Extension";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(399, 0);
            label9.Name = "label9";
            label9.Size = new Size(170, 46);
            label9.TabIndex = 8;
            label9.Text = "Supervisor";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFname.Location = new Point(179, 3);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(214, 27);
            txtFname.TabIndex = 11;
            // 
            // labelComboTitle
            // 
            labelComboTitle.AutoSize = true;
            labelComboTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComboTitle.Location = new Point(635, 213);
            labelComboTitle.Name = "labelComboTitle";
            labelComboTitle.Size = new Size(77, 20);
            labelComboTitle.TabIndex = 24;
            labelComboTitle.Text = "Employee";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.Controls.Add(txtJob, 3, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(comboOffice, 3, 1);
            tableLayoutPanel1.Controls.Add(comboRep, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(txtExtension, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLname, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(txtFname, 1, 0);
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
            // txtJob
            // 
            txtJob.Dock = DockStyle.Fill;
            txtJob.Location = new Point(575, 95);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(216, 27);
            txtJob.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(399, 92);
            label4.Name = "label4";
            label4.Size = new Size(170, 46);
            label4.TabIndex = 34;
            label4.Text = "Job Title";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboOffice
            // 
            comboOffice.Dock = DockStyle.Fill;
            comboOffice.Enabled = false;
            comboOffice.FormattingEnabled = true;
            comboOffice.Location = new Point(575, 49);
            comboOffice.Name = "comboOffice";
            comboOffice.Size = new Size(216, 28);
            comboOffice.TabIndex = 33;
            // 
            // comboRep
            // 
            comboRep.Dock = DockStyle.Fill;
            comboRep.Enabled = false;
            comboRep.FormattingEnabled = true;
            comboRep.Location = new Point(575, 3);
            comboRep.Name = "comboRep";
            comboRep.Size = new Size(216, 28);
            comboRep.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Size = new Size(170, 46);
            label3.TabIndex = 27;
            label3.Text = "Last name";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 46);
            label1.TabIndex = 26;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbEmployee
            // 
            gbEmployee.Controls.Add(tableLayoutPanel1);
            gbEmployee.Dock = DockStyle.Top;
            gbEmployee.Location = new Point(0, 0);
            gbEmployee.Name = "gbEmployee";
            gbEmployee.Size = new Size(800, 213);
            gbEmployee.TabIndex = 17;
            gbEmployee.TabStop = false;
            gbEmployee.Text = "Employee Details";
            // 
            // gridEmp
            // 
            gridEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmp.GridColor = SystemColors.ScrollBar;
            gridEmp.Location = new Point(1, 396);
            gridEmp.Name = "gridEmp";
            gridEmp.RowHeadersWidth = 51;
            gridEmp.Size = new Size(799, 82);
            gridEmp.TabIndex = 16;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(comboEmp);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnMenu);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(labelComboTitle);
            Controls.Add(gbEmployee);
            Controls.Add(gridEmp);
            Name = "EmployeeForm";
            Text = "Employees";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gbEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboEmp;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtEmail;
        private TextBox txtExtension;
        private TextBox txtLname;
        private Label label6;
        private Label label8;
        private Label label2;
        private Button btnMenu;
        private Button btnCancel;
        private Button btnInsert;
        private Button btnDelete;
        private Label label9;
        private TextBox txtFname;
        private Label labelComboTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gbEmployee;
        private DataGridView gridEmp;
        private TextBox txtJob;
        private Label label4;
        private ComboBox comboOffice;
        private ComboBox comboRep;
        private Label label3;
        private Label label1;
    }
}