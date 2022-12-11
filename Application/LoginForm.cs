using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConvienceStore
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        bool verif()
        {
            if(txtUsername.Text.Trim()==""||txtPassword.Text.Trim()=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (verif() == false)
            {
                MessageBox.Show("Please enter your account and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioManagerButton.Checked == false && radioEmployeeButton.Checked ==false)
            {
                MessageBox.Show("Please select the permission to login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string user = txtUsername.Text;
                    string pass = txtPassword.Text;
                    SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=StoreManagement;Persist Security Info=True;User ID=" + user + ";Password=" + pass);
                    //Set DataSource
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("select * from V_CheckAccount(@user,@pass) ", con);//Username and Password
                    command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        if((radioEmployeeButton.Checked && user.Contains("manager")) ||(radioManagerButton.Checked && user.Contains("employee")))
                        {
                            MessageBox.Show("Please select the correct type of user for which your account is registered!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            txtPassword.Clear();
                            txtUsername.Clear();
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check Username or Password again!", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

    }
}
