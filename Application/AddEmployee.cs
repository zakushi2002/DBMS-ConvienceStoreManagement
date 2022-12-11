using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ConvienceStore
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
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
                        MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
