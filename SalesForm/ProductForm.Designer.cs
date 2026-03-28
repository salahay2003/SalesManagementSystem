namespace SalesForm
{
    partial class ProductForm
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
            comboProduct = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtPrice = new TextBox();
            label4 = new Label();
            comboPL = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnMenu = new Button();
            btnCancel = new Button();
            btnInsert = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtQty = new TextBox();
            txtMSRP = new TextBox();
            label5 = new Label();
            txtDesc = new TextBox();
            txtVendor = new TextBox();
            txtScale = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label2 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            labelComboTitle = new Label();
            gbProduct = new GroupBox();
            gridPro = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPro).BeginInit();
            SuspendLayout();
            // 
            // comboProduct
            // 
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new Point(635, 242);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(151, 28);
            comboProduct.TabIndex = 31;
            comboProduct.Text = "Product..";
            comboProduct.SelectedIndexChanged += comboPro_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(12, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(575, 95);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 27);
            txtPrice.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(399, 92);
            label4.Name = "label4";
            label4.Size = new Size(170, 46);
            label4.TabIndex = 34;
            label4.Text = "Price";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboPL
            // 
            comboPL.Dock = DockStyle.Fill;
            comboPL.Enabled = false;
            comboPL.FormattingEnabled = true;
            comboPL.Location = new Point(575, 3);
            comboPL.Name = "comboPL";
            comboPL.Size = new Size(216, 28);
            comboPL.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 46);
            label3.Name = "label3";
            label3.Size = new Size(170, 46);
            label3.TabIndex = 27;
            label3.Text = "Scale";
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
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(692, 335);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(94, 29);
            btnMenu.TabIndex = 35;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(121, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 216);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 32;
            btnInsert.Text = "Insert new ";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7777786F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txtQty, 3, 1);
            tableLayoutPanel1.Controls.Add(txtMSRP, 3, 3);
            tableLayoutPanel1.Controls.Add(label5, 2, 3);
            tableLayoutPanel1.Controls.Add(txtPrice, 3, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 2);
            tableLayoutPanel1.Controls.Add(comboPL, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtDesc, 1, 3);
            tableLayoutPanel1.Controls.Add(txtVendor, 1, 2);
            tableLayoutPanel1.Controls.Add(txtScale, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 2, 0);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
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
            // txtQty
            // 
            txtQty.Dock = DockStyle.Fill;
            txtQty.Location = new Point(575, 49);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(216, 27);
            txtQty.TabIndex = 38;
            // 
            // txtMSRP
            // 
            txtMSRP.Dock = DockStyle.Fill;
            txtMSRP.Location = new Point(575, 141);
            txtMSRP.Name = "txtMSRP";
            txtMSRP.Size = new Size(216, 27);
            txtMSRP.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(399, 138);
            label5.Name = "label5";
            label5.Size = new Size(170, 49);
            label5.TabIndex = 36;
            label5.Text = "MSRP";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDesc
            // 
            txtDesc.Dock = DockStyle.Fill;
            txtDesc.Location = new Point(179, 141);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(214, 27);
            txtDesc.TabIndex = 23;
            // 
            // txtVendor
            // 
            txtVendor.Dock = DockStyle.Fill;
            txtVendor.Location = new Point(179, 95);
            txtVendor.Name = "txtVendor";
            txtVendor.Size = new Size(214, 27);
            txtVendor.TabIndex = 22;
            // 
            // txtScale
            // 
            txtScale.Dock = DockStyle.Fill;
            txtScale.Location = new Point(179, 49);
            txtScale.Name = "txtScale";
            txtScale.Size = new Size(214, 27);
            txtScale.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 138);
            label6.Name = "label6";
            label6.Size = new Size(170, 49);
            label6.TabIndex = 5;
            label6.Text = "Description";
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
            label8.Text = "Quantity";
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
            label2.Text = "Vendor";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(399, 0);
            label9.Name = "label9";
            label9.Size = new Size(170, 46);
            label9.TabIndex = 8;
            label9.Text = "Product Line";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(179, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 335);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // labelComboTitle
            // 
            labelComboTitle.AutoSize = true;
            labelComboTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComboTitle.Location = new Point(635, 213);
            labelComboTitle.Name = "labelComboTitle";
            labelComboTitle.Size = new Size(64, 20);
            labelComboTitle.TabIndex = 34;
            labelComboTitle.Text = "Product";
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(tableLayoutPanel1);
            gbProduct.Dock = DockStyle.Top;
            gbProduct.Location = new Point(0, 0);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new Size(800, 213);
            gbProduct.TabIndex = 27;
            gbProduct.TabStop = false;
            gbProduct.Text = "Product Details";
            // 
            // gridPro
            // 
            gridPro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPro.GridColor = SystemColors.ScrollBar;
            gridPro.Location = new Point(1, 382);
            gridPro.Name = "gridPro";
            gridPro.RowHeadersWidth = 51;
            gridPro.Size = new Size(799, 82);
            gridPro.TabIndex = 26;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboProduct);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnMenu);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(labelComboTitle);
            Controls.Add(gbProduct);
            Controls.Add(gridPro);
            Name = "ProductForm";
            Text = "Products";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            gbProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboProduct;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtPrice;
        private Label label4;
        private ComboBox comboPL;
        private Label label3;
        private Label label1;
        private Button btnMenu;
        private Button btnCancel;
        private Button btnInsert;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDesc;
        private TextBox txtVendor;
        private TextBox txtScale;
        private Label label6;
        private Label label8;
        private Label label2;
        private Label label9;
        private TextBox txtName;
        private Button btnDelete;
        private Label labelComboTitle;
        private GroupBox gbProduct;
        private DataGridView gridPro;
        private TextBox txtMSRP;
        private Label label5;
        private TextBox txtQty;
    }
}