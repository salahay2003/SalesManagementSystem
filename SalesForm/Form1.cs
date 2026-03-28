using Microsoft.EntityFrameworkCore;
using SalesManagementSystem.Data.Context;
using SalesManagementSystem.Data.Models;


namespace SalesForm
{
    public partial class Form1 : Form
    {
        private bool updateFlag = false;
        private SalesDbCOntext db = new SalesDbCOntext();
        public Form1()
        {
            InitializeComponent();
            FillCustomerComboBox();
        }

        private void FillCustomerComboBox()
        {

            comboCustomer.DisplayMember = "Name";
            comboCustomer.ValueMember = "Id";
            comboCustomer.DataSource = db.Customers.ToList();
            FillEmpComboBox();
        }

        public void FillEmpComboBox()
        {
            comboSales.DisplayMember = "FirstName";
            comboSales.ValueMember = "Id";
            comboSales.DataSource = db.Employees
                                         .AsNoTracking()
                                         .ToList();
        }


        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c_id = (int)comboCustomer.SelectedValue;
            var customer = db.Customers.Include(c => c.Employee).Where(c => c.Id == c_id);
            gridCustomers.DataSource = customer.ToList();
            var cust = customer.FirstOrDefault(c => c.Id == c_id);
            if (cust != null)
            {
                txtFname.Text = cust.FirstName;
                txtLname.Text = cust.LastName;
                txtPhone.Text = cust.Phone;
                txtCname.Text = cust.Name;
                txtAddress.Text = cust.Address1;
                txtCity.Text = cust.City;
                comboSales.SelectedValue = cust.SalesRepNum;
                txtState.Text = cust.State;
                txtCountry.Text = cust.Country;
                txtCredit.Text = cust.CreditLimit.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            gbCustomer.Text = "Insert New Customer..";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            gridCustomers.DataSource = null;
            comboCustomer.Enabled = false;
            btnInsert.Enabled = false;
            ClearFeilds();
            comboSales.Enabled = true;

        }
        private void ClearFeilds()
        {
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtCname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            comboSales.SelectedValue = string.Empty;
            txtState.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCredit.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Name = txtCname.Text,
                FirstName = txtFname.Text,
                LastName = txtLname.Text,
                Phone = txtPhone.Text,
                Address1 = txtAddress.Text,
                City = txtCity.Text,
                SalesRepNum = (int)comboSales.SelectedValue,
                State = txtState.Text,
                Country = txtCountry.Text,
            };
            db.Add(customer);
            db.SaveChanges();
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
            comboCustomer.Enabled = true;
            comboSales.Enabled = false;
            MessageBox.Show(
               $"Customer {txtCname.Text} Added successfully.",
               "Success",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
            ClearFeilds();
            FillCustomerComboBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
            comboCustomer.Enabled = true;
            gbCustomer.Text = "Customer Detils";
            updateFlag = false;
            comboSales.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {comboCustomer.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                var id = comboCustomer.SelectedValue;
                var customer = db.Customers.FirstOrDefault(c => c.Id == (int)id);
                if(customer != null)
                {db.Customers.Remove(customer);
                db.SaveChanges();
                FillCustomerComboBox();
                    MessageBox.Show(
                        "Customer deleted successfully.",
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
                gbCustomer.Text = "Updating Customer..";
                btnCancel.Enabled = true;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                comboCustomer.Enabled = false;
                comboSales.Enabled = true;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                $"Are you sure you want to update {comboCustomer.Text}?",
                "Confirm Upate",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var customer = db.Customers.FirstOrDefault(c => c.Id == (int)comboCustomer.SelectedValue);
                    if (customer != null)
                    {
                        UpdateCustomer(customer);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show(
                    $"Customer {comboCustomer.Text} updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                FillCustomerComboBox();
                btnCancel.PerformClick();
            }
        }

        private void UpdateCustomer(Customer customer)
        {
            if (customer != null)
            {
                customer.Name = txtCname.Text;
                customer.FirstName = txtFname.Text;
                customer.LastName = txtLname.Text;
                customer.Phone = txtPhone.Text;
                customer.Address1 = txtAddress.Text;
                customer.City = txtCity.Text;
                customer.SalesRepNum = (int)comboSales.SelectedValue;
                customer.State = txtState.Text;
                customer.Country = txtCountry.Text;
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
