using SalesManagementSystem.Data.Context;
using SalesManagementSystem.Data.Models;
using System.Data;


namespace SalesForm
{

    public partial class ProductForm : Form
    {
        private bool updateFlag = false;
        private bool insertFlag = false;
        
        private SalesDbCOntext db = new SalesDbCOntext();
        public ProductForm()
        {
            InitializeComponent();
            FillProductComboBox();
        }


        private void FillProductComboBox()
        {

            comboProduct.DisplayMember = "Name";
            comboProduct.ValueMember = "Code";
            comboProduct.DataSource = db.Products.ToList();
            FillPlComboBox();
        }
        public void FillPlComboBox()
        {
            comboPL.DisplayMember = "DescInText";
            comboPL.ValueMember = "Id";
            comboPL.DataSource = db.ProductLines.ToList();
        }

        private void comboPro_SelectedIndexChanged(object sender, EventArgs e)
        {

            var p_id = (int)comboProduct.SelectedValue;
            var pro = db.Products.Where(c => c.Code == p_id);
            gridPro.DataSource = pro.ToList();
            var product = pro.FirstOrDefault(c => c.Code == p_id);
            if (product != null)
            {
                txtName.Text = product.Name;
                txtScale.Text = product.Scale.ToString();
                txtVendor.Text = product.Vendor;
                txtDesc.Text = product.PdtDescription;
                txtPrice.Text = product.BuyPrice.ToString();
                txtMSRP.Text = product.MSRP;
                txtQty.Text = product.QtyInStock.ToString();
                comboPL.SelectedValue = product.ProductLineId;
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            gbProduct.Text = "Insert New Product..";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            gridPro.DataSource = null;
            comboProduct.Enabled = false;
            comboProduct.Text = string.Empty;
            btnInsert.Enabled = false;
            ClearFeilds();
            comboPL.Enabled = true;
            insertFlag = true;

        }
        private void ClearFeilds()
        {
            txtName.Text = string.Empty;
            txtScale.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtVendor.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtMSRP.Text = string.Empty;
            comboPL.SelectedValue = string.Empty;
            txtQty.Text = string.Empty;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = txtName.Text,
                Scale = int.Parse(txtScale.Text),
                PdtDescription = txtDesc.Text,
                Vendor = txtVendor.Text,
                BuyPrice = decimal.Parse(txtPrice.Text),
                ProductLineId = (int)comboPL.SelectedValue,
                MSRP = txtMSRP.Text,
                QtyInStock = int.Parse(txtQty.Text)

            };
            try
            {

                db.Add(product);
                db.SaveChanges();
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnInsert.Enabled = true;
                comboProduct.Enabled = true;
                comboPL.Enabled = false;
                MessageBox.Show(
                   $"Product {txtName.Text} Added successfully.",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );
                ClearFeilds();
                FillProductComboBox();
            }
            catch { }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
            comboProduct.Enabled = true;
            gbProduct.Text = "Product Detils";
            comboPL.Enabled = false;
            btnCancel.Enabled = false;
            updateFlag = false;
            ClearFeilds();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {comboProduct.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                var id = comboProduct.SelectedValue;
                var product = db.Products.FirstOrDefault(c => c.Code == (int)id);
                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    FillProductComboBox();
                    MessageBox.Show(
                        "Product deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!updateFlag)
            {
                updateFlag = true;
                gbProduct.Text = "Updating Product..";
                btnCancel.Enabled = true;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                comboProduct.Enabled = false;
                comboPL.Enabled = true;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                $"Are you sure you want to update {comboProduct.Text}?",
                "Confirm Upate",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var product = db.Products
                        .FirstOrDefault(c => c.Code == (int)comboProduct.SelectedValue);
                    if (product != null)
                    {
                        UpdateProduct(product);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show(
                    $"Product {comboProduct.Text} updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                FillProductComboBox();
                btnCancel.PerformClick();
            }
        }

        private void UpdateProduct(Product pro)
        {
            if (pro != null)
            {
                pro.Name = txtName.Text;
                pro.Scale = int.Parse(txtScale.Text);
                pro.PdtDescription = txtDesc.Text;
                pro.BuyPrice = int.Parse(txtPrice.Text);
                pro.Vendor = txtVendor.Text;
                pro.ProductLineId = (int)comboPL.SelectedValue;
                pro.QtyInStock = int.Parse(txtQty.Text);
                pro.MSRP = txtMSRP.Text;
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
