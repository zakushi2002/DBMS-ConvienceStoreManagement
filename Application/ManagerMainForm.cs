using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvienceStore
{
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }

        private void addEmployeeForm_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }

        private void manageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.ShowDialog();
        }

        private void addProductForm_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void listProductForm_Click(object sender, EventArgs e)
        {

        }

        private void manageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct();
            manageProduct.ShowDialog();
        }

        private void manageType_Click(object sender, EventArgs e)
        {
            ManageType manageType = new ManageType();
            manageType.ShowDialog();
        }

        private void manageManuafacture_Click(object sender, EventArgs e)
        {
            ManageManuafacture manageManuafacture = new ManageManuafacture();
            manageManuafacture.ShowDialog();
        }

        private void manageSupply_Click(object sender, EventArgs e)
        {
            ManageSupply manageSupply = new ManageSupply();
            manageSupply.ShowDialog();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {

        }

        private void manageCustomer_Click(object sender, EventArgs e)
        {

        }

        private void employeeStatisticsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void revenueStatisticsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInvoice invoice = new ManageInvoice();
            invoice.ShowDialog();
        }
    }
}
