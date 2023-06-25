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
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void manageInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInvoice invoice = new ManageInvoice();
            invoice.ShowDialog();
        }
    }
}
