using Microsoft.EntityFrameworkCore;
using SalesManagementSystem.Data.Context;
using SalesManagementSystem.Data.Models;
using System.Data;


namespace SalesForm
{
    public partial class EmployeeForm : Form
    {
        private bool updateFlag = false;
        private SalesDbCOntext db = new SalesDbCOntext();
        public EmployeeForm()
        {
            InitializeComponent();
            FillEmpComboBox();
        }

        private void FillEmpComboBox()
        {

            comboEmp.DisplayMember = "FirstName";
            comboEmp.ValueMember = "Id";
            comboEmp.DataSource = db.Employees.ToList();
            FillRepComboBox();
            FillOfficeComboBox();
        }
        public void FillRepComboBox()
        {
            comboRep.DisplayMember = "FirstName";
            comboRep.ValueMember = "Id";
            comboRep.DataSource = db.Employees
                                         .AsNoTracking()
                                         .ToList();
        }
        public void FillOfficeComboBox()
        {

            comboOffice.DisplayMember = "Code";
            comboOffice.ValueMember = "Code";
            comboOffice.DataSource = db.Offices
                                         .AsNoTracking()
                                         .ToList();
        }

        private void comboEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var c_id = (int)comboEmp.SelectedValue;
            var emp = db.Employees.Include(c => c.Office).Where(c => c.Id == c_id);
            gridEmp.DataSource = emp.ToList();
            var employee = emp.FirstOrDefault(c => c.Id == c_id);
            if (employee != null)
            {
                txtFname.Text = employee.FirstName;
                txtLname.Text = employee.LastName;
                txtExtension.Text = employee.Extension;
                txtEmail.Text = employee.Email;
                txtJob.Text = employee.JobTitle;
                comboOffice.SelectedValue = employee.OfficeCode;
                comboRep.SelectedValue = employee.ReportsTo;
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            gbEmployee.Text = "Insert New Employee..";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            gridEmp.DataSource = null;
            comboEmp.Enabled = false;
            btnInsert.Enabled = false;
            ClearFeilds();
            comboOffice.Enabled = true;
            comboRep.Enabled = true;

        }
        private void ClearFeilds()
        {
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtExtension.Text = string.Empty;
            txtJob.Text = string.Empty;
            comboOffice.SelectedValue = string.Empty;
            comboRep.SelectedValue = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FirstName = txtFname.Text,
                LastName = txtLname.Text,
                Email = txtEmail.Text,
                Extension = txtExtension.Text,
                JobTitle = txtJob.Text,
                OfficeCode = (int)comboOffice.SelectedValue,
                ReportsTo = (int)comboRep.SelectedValue
            };
            try
            {

            db.Add(employee);
            db.SaveChanges();
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
            comboEmp.Enabled = true;
            comboOffice.Enabled = false;
            comboRep.Enabled = false;
            MessageBox.Show(
               $"Employee {txtFname.Text} Added successfully.",
               "Success",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
            ClearFeilds();
            FillEmpComboBox();
            }
            catch { }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
            comboEmp.Enabled = true;
            gbEmployee.Text = "Employee Detils";
            updateFlag = false;
            comboOffice.Enabled = false;
            comboRep.Enabled = false;
            ClearFeilds();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {comboEmp.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                var id = comboEmp.SelectedValue;
                var employee = db.Employees.FirstOrDefault(c => c.Id == (int)id);
                if(employee != null)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    FillEmpComboBox();
                    MessageBox.Show(
                        "Employee deleted successfully.",
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
                gbEmployee.Text = "Updating Employee..";
                btnCancel.Enabled = true;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                comboEmp.Enabled = false;
                comboOffice.Enabled = true;
                comboRep.Enabled = true;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                $"Are you sure you want to update {comboEmp.Text}?",
                "Confirm Upate",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var employee = db.Employees
                        .FirstOrDefault(c => c.Id == (int)comboEmp.SelectedValue);
                    if (employee != null)
                    {
                        UpdateEmployee(employee);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show(
                    $"Employee {comboEmp.Text} updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                FillEmpComboBox();
                btnCancel.PerformClick();
            }
        }

        private void UpdateEmployee(Employee emp)
        {
            if (emp != null)
            {
                emp.FirstName = txtFname.Text;
                emp.LastName = txtLname.Text;
                emp.Email = txtEmail.Text;
                emp.JobTitle = txtJob.Text;
                emp.Extension = txtExtension.Text;
                emp.OfficeCode = (int)comboOffice.SelectedValue;
                emp.ReportsTo = (int)comboRep.SelectedValue;
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
