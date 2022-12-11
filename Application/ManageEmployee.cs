using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ConvienceStore
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        bool verif()
        {
            if ((txtEmployeeID.Text.Trim() == "")
                || (txtBoxName.Text.Trim() == "")
                || (txtBoxAddress.Text.Trim() == "")
                || (txtBoxPhone.Text.Trim() == "")
                || (txtBoxSalary.Text.Trim() == "")
                || (PictureBoxEmployeeImage.Image == null)
                || (radioButtonMale.Checked == false && radioButtonFemale.Checked == false))
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
            string id = txtEmployeeID.Text;
            string name = txtBoxName.Text;
            DateTime date = dateTimePicker.Value;
            string address = txtBoxAddress.Text;
            string phone = txtBoxPhone.Text;
            string position = comboBoxPosition.Text;
            double salary = Convert.ToDouble(txtBoxSalary.Text);
            string gender = "Male";
            if (radioButtonMale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                try
                {
                    PictureBoxEmployeeImage.Image.Save(pic, PictureBoxEmployeeImage.Image.RawFormat);
                    if (employee.insertEmployee(id, name, date, gender, phone, address, position, salary, pic))
                    {
                        txtEmployeeID.Clear();
                        txtBoxName.Clear();
                        txtBoxPhone.Clear();
                        txtBoxSalary.Clear();
                        txtBoxAddress.Clear();
                        dateTimePicker.Value = DateTime.Now;
                        radioButtonFemale.Checked = false;
                        radioButtonMale.Checked = false;
                        PictureBoxEmployeeImage.Image = null;
                        MessageBox.Show("New Employee Added", "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeID.Text;
            string name = txtBoxName.Text;
            DateTime date = dateTimePicker.Value;
            string address = txtBoxAddress.Text;
            string phone = txtBoxPhone.Text;
            string position = comboBoxPosition.Text;
            double salary = Convert.ToDouble(txtBoxSalary.Text);
            string gender = "Male";
            if (radioButtonMale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                try
                {
                    PictureBoxEmployeeImage.Image.Save(pic, PictureBoxEmployeeImage.Image.RawFormat);
                    if (employee.updateEmployee(id, name, date, gender, phone, address, position, salary, pic))
                    {
                        txtEmployeeID.Clear();
                        txtBoxName.Clear();
                        txtBoxPhone.Clear();
                        txtBoxSalary.Clear();
                        txtBoxAddress.Clear();
                        dateTimePicker.Value = DateTime.Now;
                        radioButtonFemale.Checked = false;
                        radioButtonMale.Checked = false;
                        PictureBoxEmployeeImage.Image = null;
                        MessageBox.Show("Employee Edited", "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Employee ID To Delete!", "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (employee.deleteEmployee(txtEmployeeID.Text))
                    {
                        txtEmployeeID.Clear();
                        txtBoxName.Clear();
                        txtBoxPhone.Clear();
                        txtBoxSalary.Clear();
                        txtBoxAddress.Clear();
                        dateTimePicker.Value = DateTime.Now;
                        radioButtonFemale.Checked = false;
                        radioButtonMale.Checked = false;
                        PictureBoxEmployeeImage.Image = null;
                        MessageBox.Show("Employee Deleted", "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manage Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxEmployeeImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("employee_" + txtEmployeeID.Text);
            if ((PictureBoxEmployeeImage.Image == null))
                MessageBox.Show("No Image in Picture Box");
            else if ((svf.ShowDialog() == DialogResult.OK))
                PictureBoxEmployeeImage.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fillGrid("find");
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            fillGrid("load");
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {

        }
        public void fillGrid(string type)
        {
            dataGridView.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridView.RowTemplate.Height = 80;
            if (type == "load")
            {
                dataGridView.DataSource = employee.getEmployee("EXEC SP_ListEmployee");
            }
            else if(type == "find")
            {
                dataGridView.DataSource = employee.getEmployee("EXEC SP_FindEmployee "+txtSearchBox.Text);
            }
            picCol = (DataGridViewImageColumn)dataGridView.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView.AllowUserToAddRows = false;
            labelTotalEmployees.Text = "Total Employees: "+employee.totalEmployees();
        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dataGridView.ShowCellErrors = true;
        }
    }
}
