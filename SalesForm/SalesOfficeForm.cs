using SalesManagementSystem.Data.Context;
using SalesManagementSystem.Data.Models;
using System.Data;

namespace SalesForm
{
    public partial class SalesOfficeForm : Form
    {
        private bool updateFlag = false;
        private SalesDbCOntext db = new SalesDbCOntext();
        public SalesOfficeForm()
        {
            InitializeComponent();
            FillOfficeComboBox();

        }

        private void FillOfficeComboBox()
        {
            comboOffice.DisplayMember = "Code";
            comboOffice.ValueMember = "Code";
            comboOffice.DataSource = db.Offices.ToList();
        
        }
        private void comboOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var o_id = (int)comboOffice.SelectedValue;
            var office = db.Offices.Where(o => o.Code == o_id);
            gridOffice.DataSource = office.ToList();
            var off = office.FirstOrDefault(c => c.Code == o_id);
            if (off != null)
            {
                txtCity.Text =         off.City;    
                txtPhone.Text =        off.Phone;
                txtAddressOne.Text =   off.Address1;
                txtAddressTwo.Text =   off.Address2;
                tstState.Text =        off.State;
                txtPCODE.Text =        off.PostalCode.ToString();
                txtCountry.Text =      off.Country;
                txtTerirtory.Text =    off.Territory;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            gbOffice.Text = "Insert New Office..";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            gridOffice.DataSource = null;
            comboOffice.Enabled = false;
            btnInsert.Enabled = false;
            ClearFeilds();
            
        }
        private void ClearFeilds()
        {
            txtCity.Text =       string.Empty;
            txtPhone.Text =      string.Empty;
            txtAddressOne.Text = string.Empty;
            txtAddressTwo.Text = string.Empty;
            tstState.Text =      string.Empty;
            txtPCODE.Text =      string.Empty;
            txtCountry.Text =    string.Empty;
            txtTerirtory.Text =  string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Office office = new Office()
            {
                
                    City = txtCity.Text,
                    Phone = txtPhone.Text,
                    Address1 = txtAddressOne.Text,
                    Address2 = txtAddressTwo.Text,
                    State = tstState.Text,
                PostalCode = int.Parse(txtPCODE.Text),
                    Country = txtCountry.Text,
                Territory = txtTerirtory.Text
                            
            };
            db.Add(office);
            db.SaveChanges();
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
            comboOffice.Enabled = true;
            MessageBox.Show(
               $"Office: {office.Code} Added successfully.",
               "Success",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
            ClearFeilds();
            FillOfficeComboBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnInsert.Enabled = true;
            comboOffice.Enabled = true;
            gbOffice.Text = "Office Detils";
            updateFlag = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Office code: {comboOffice.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                try
                {

                    var id = comboOffice.SelectedValue;
                    var office = db.Offices.FirstOrDefault(c => c.Code == (int)id);
                    if (office != null)
                    {
                        db.Offices.Remove(office);
                        db.SaveChanges();
                        FillOfficeComboBox();
                        MessageBox.Show(
                            "Office deleted successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                            $"Cannot delete office, make sure to resolve dependencies",
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
                gbOffice.Text = "Updating Office..";
                btnCancel.Enabled = true;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                comboOffice.Enabled = false;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                $"Are you sure you want to update {comboOffice.Text}?",
                "Confirm Upate",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
                try
                { 
                    if (result == DialogResult.Yes)
                    {
                        var office = db.Offices.FirstOrDefault(c => c.Code == (int)comboOffice.SelectedValue!);
                        if (office != null)
                        {
                            UpdateOffice(office);
                            db.SaveChanges();
                        }
                    }
                    MessageBox.Show(
                        $"Office {comboOffice.Text} updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    FillOfficeComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Office {comboOffice.Text} update was unseccessfull.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                btnCancel.PerformClick();
            }
        }

        private void UpdateOffice(Office office)
        {
            if (office != null)
            {
                office.City = txtCity.Text;
                office.PostalCode = int.Parse(txtPCODE.Text);
                office.Phone = txtPhone.Text;
                office.Address1 = txtAddressOne.Text;
                office.City = txtCity.Text;
                office.State = tstState.Text;
                office.Country = txtCountry.Text;
                office.Territory = txtTerirtory.Text;
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

