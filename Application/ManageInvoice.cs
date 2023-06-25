using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvienceStore
{
    public partial class ManageInvoice : Form
    {
        public ManageInvoice()
        {
            InitializeComponent();
        }
        Invoice invoice = new Invoice();
        Customer customer = new Customer();
        Product product = new Product();
        bool verIfDetail()
        {
            if ((txtInvoiceID.Text.Trim() == "")
                || (txtBoxProductID.Text.Trim() == "")
                || (numericUpDown.Value == 0)
                || (txtBoxPrice.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool verIfInvoice()
        {
            if ((txtInvoiceID.Text.Trim() == "")
                || (txtEmployeeID.Text.Trim() == "")
                || (invoice.totalPay(txtInvoiceID.Text) == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            
            DataTable cus = customer.getCustomer("Select * FROM FN_FindCustomer('" + txtBoxPhone.Text + "')");
            if (cus.Rows.Count > 0)
            {
                txtBoxCustomerID.Text = cus.Rows[0]["cid"].ToString();
                txtBoxCustomerName.Text = cus.Rows[0]["cname"].ToString();
            }
            else
            {
                MessageBox.Show("Not Found", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }

        private void txtBoxProductID_TextChanged(object sender, EventArgs e)
        {
            DataTable pro = product.getProduct("SELECT * FROM FN_AutoShowProductInfo('" + txtBoxProductID.Text + "')");
            if(pro.Rows.Count > 0)
            {
                txtBoxProductName.Text = pro.Rows[0]["pname"].ToString();
                txtBoxPrice.Text = pro.Rows[0]["pprice"].ToString();
                labelUnit.Text = "/"+pro.Rows[0]["unitname"].ToString();
                //code xu ly hinh anh
                byte[] pic;
                pic = (byte[])pro.Rows[0]["pimage"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxProduct.Image = Image.FromStream(picture);
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtBoxPrice.Text) * (double)numericUpDown.Value;
            if (total > 0)
            {
                txtBoxIntoMoney.Text = total + " VND";
            }
        }

        private void ManageInvoice_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        void fillGrid()
        {
            dataGridView1.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridView1.RowTemplate.Height = 80;

            dataGridView1.DataSource = product.getProduct("SELECT * FROM V_Product_Invoice");
            dataGridView1.ShowCellErrors = true;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;


            dataGridView2.ReadOnly = true;

            dataGridView2.DataSource = invoice.getDetail("SELECT * FROM Fn_ShowDetail('"+txtInvoiceID.Text+"')");
            dataGridView2.ShowCellErrors = true;
            dataGridView1.AllowUserToAddRows = false;
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtBoxProductID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            double total = Convert.ToDouble(txtBoxPrice.Text) * (double)numericUpDown.Value;
            txtBoxIntoMoney.Text = total + " VND";
        }

        private void addToInvoiceButton_Click(object sender, EventArgs e)
        {
            string iid = txtInvoiceID.Text.Trim();
            string pid = txtBoxProductID.Text.Trim();
            int damount = Convert.ToInt32(numericUpDown.Value);
            double dprice = Convert.ToDouble(txtBoxPrice.Text);
            if (verIfDetail())
            {
                try
                {
                    if (invoice.insertDetail(iid,pid, damount, dprice)==false)
                    {
                        fillGrid();
                        labelTotalPay.Text = "Total Pay: " + invoice.totalPay(txtInvoiceID.Text) + " VND";
                        MessageBox.Show("Product has been added to the invoice", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void removeFromInvoicebutton_Click(object sender, EventArgs e)
        {
            string iid = txtInvoiceID.Text.Trim();
            string pid = txtBoxProductID.Text.Trim();
            if (verIfDetail())
            {
                try
                {
                    if (invoice.deleteDetail(iid, pid) == false)
                    {
                        fillGrid();
                        labelTotalPay.Text = "Total Pay: " + invoice.totalPay(txtInvoiceID.Text) + " VND";
                        MessageBox.Show("Product has been deleted from the invoice", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            txtBoxProductID.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtInvoiceID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            numericUpDown.Value = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value);
            double total = Convert.ToDouble(txtBoxPrice.Text) * (double)numericUpDown.Value;
            txtBoxIntoMoney.Text = total + " VND";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string iid = txtInvoiceID.Text;
            string eid = txtEmployeeID.Text;
            string cid =txtBoxCustomerID.Text;
            DateTime idate = dateTimePicker.Value;
            double itotalpay = invoice.totalPay(txtInvoiceID.Text);

            if (verIfInvoice())
            {
                try
                {
                    if (txtBoxCustomerID.Text.Trim() == "")
                    {
                        if (invoice.updateInvoice(iid, eid, idate, itotalpay))
                        {
                            fillGrid();
                            MessageBox.Show("Invoice added successfully!", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        if (invoice.updateInvoice(iid, eid, cid, idate, itotalpay))
                        {
                            fillGrid();
                            MessageBox.Show("Invoice added successfully!", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Manage Invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
