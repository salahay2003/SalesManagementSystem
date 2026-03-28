namespace SalesForm
{
    partial class MainForm
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
            btnCustomer = new Button();
            btnProducts = new Button();
            btnEmployees = new Button();
            btnOffices = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Wheat;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.Dock = DockStyle.Fill;
            btnCustomer.Location = new Point(3, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(185, 87);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Customers";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Wheat;
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.Dock = DockStyle.Fill;
            btnProducts.Location = new Point(194, 3);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(185, 87);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.AutoSize = true;
            btnEmployees.BackColor = Color.Wheat;
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.Dock = DockStyle.Fill;
            btnEmployees.Location = new Point(385, 3);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(185, 87);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnOffices
            // 
            btnOffices.BackColor = Color.Wheat;
            btnOffices.Cursor = Cursors.Hand;
            btnOffices.Dock = DockStyle.Fill;
            btnOffices.Location = new Point(576, 3);
            btnOffices.Name = "btnOffices";
            btnOffices.Size = new Size(185, 87);
            btnOffices.TabIndex = 3;
            btnOffices.Text = "Offices";
            btnOffices.UseVisualStyleBackColor = false;
            btnOffices.Click += btnOrders_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnCustomer, 0, 0);
            tableLayoutPanel1.Controls.Add(btnOffices, 3, 0);
            tableLayoutPanel1.Controls.Add(btnProducts, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEmployees, 2, 0);
            tableLayoutPanel1.Location = new Point(6, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(764, 93);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 102);
            label1.Name = "label1";
            label1.Size = new Size(528, 54);
            label1.TabIndex = 5;
            label1.Text = "Sales Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Sales Management System";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomer;
        private Button btnProducts;
        private Button btnEmployees;
        private Button btnOffices;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}