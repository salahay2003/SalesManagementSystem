using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SalesOfficeForm form = new SalesOfficeForm();
            form.ShowDialog();
        }
    }
}
