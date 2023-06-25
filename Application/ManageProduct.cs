using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ConvienceStore
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }
        Product product = new Product();
        bool verif()
        {
            if ((txtBoxProductID.Text.Trim() == "")
                || (txtBoxProductName.Text.Trim() == "")
                || (txtBoxPrice.Text.Trim() == "")
                || (comboBoxType.Text.Trim() == "")
                || (comboBoxUnit.Text.Trim() == "")
                || (pictureBoxProduct.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string id = txtBoxProductID.Text;
            string name = txtBoxProductName.Text;
            string type = comboBoxType.Text;
            double price = Convert.ToDouble(txtBoxPrice.Text);
            string unit = comboBoxUnit.Text;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                try
                {
                    pictureBoxProduct.Image.Save(pic, pictureBoxProduct.Image.RawFormat);
                    if (product.insertProduct(id, name,price,type,unit, pic))
                    {
                        fillGrid("load");
                        MessageBox.Show("New Product Added", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void fillGrid(string type)
        {            
            dataGridView.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridView.RowTemplate.Height = 80;
            if (type == "load")
            {
                comboBoxType.DataSource = product.getType("SELECT * FROM V_Type");
                comboBoxType.DisplayMember = "tid";
                comboBoxType.ValueMember = "tid";
                comboBoxType.SelectedValue = -1;
                dataGridView.DataSource = product.getProduct("SELECT * FROM V_Product");
            }
            else if (type == "find")
            {
                if (txtSearchBox.Text.Trim() != "")
                {
                    dataGridView.DataSource = product.getProduct("SELECT * FROM  FN_FindProduct('" + txtSearchBox.Text+"')");
                }
            }
            dataGridView.ShowCellErrors = true;
            picCol = (DataGridViewImageColumn)dataGridView.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView.AllowUserToAddRows = false;
            labelTotalProduct.Text = "Total Products: " + dataGridView.Rows.Count;
        }
        private void ManageProduct_Load(object sender, EventArgs e)
        {
            fillGrid("load");   
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string id = txtBoxProductID.Text;
            string name = txtBoxProductName.Text;
            string type = comboBoxType.Text;
            double price = Convert.ToDouble(txtBoxPrice.Text);
            string unit = comboBoxUnit.Text;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                try
                {
                    pictureBoxProduct.Image.Save(pic, pictureBoxProduct.Image.RawFormat);
                    if (product.UpdateProduct(id, name, price, type, unit, pic))
                    {
                        fillGrid("load");
                        MessageBox.Show("Product Edited", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxProduct.Image = Image.FromFile(opf.FileName);
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("product_" + txtBoxProductID.Text);
            if ((pictureBoxProduct.Image == null))
                MessageBox.Show("No Image in Picture Box");
            else if ((svf.ShowDialog() == DialogResult.OK))
                pictureBoxProduct.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (txtBoxProductID.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Product ID To Delete!", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (product.deleteProduct(txtBoxProductID.Text))
                    {
                        fillGrid("load");
                        MessageBox.Show("Product Deleted", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fillGrid("find");
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dataGridView.ShowCellErrors = true;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            txtBoxProductID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtBoxProductName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtBoxPrice.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            comboBoxType.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            comboBoxUnit.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            //code xu ly hinh anh
            byte[] pic;
            pic = (byte[])dataGridView.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxProduct.Image = Image.FromStream(picture);
        }
    }
}
