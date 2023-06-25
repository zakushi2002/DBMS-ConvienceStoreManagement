using System.Data;
using System.Data.SqlClient;

namespace ConvienceStore
{
    public class MY_DB
    {
        //Phan quyen doi voi Manager
        SqlConnection con1 = new SqlConnection(@"Data Source=MSI;Initial Catalog=StoreManagement;Persist Security Info=True;User ID=managerAdmin;Password=1");
        public SqlConnection getConnectionManager
        {
            get
            {
                return con1;
            }
        }
        public void openConnectionManager()
        {
            if ((con1.State == ConnectionState.Closed))
            {
                con1.Open();
            }
        }
        public void closeConnectionManager()
        {
            if ((con1.State == ConnectionState.Closed))
            {
                con1.Close();
            }
        }
        //Phan quyen doi voi Employee
        SqlConnection con2 = new SqlConnection(@"Data Source=MSI;Initial Catalog=StoreManagement;Persist Security Info=True;User ID=employeeUser;Password=1");
        public SqlConnection getConnectionEmployee
        {
            get
            {
                return con2;
            }
        }
        public void openConnectionEmployee()
        {
            if ((con2.State == ConnectionState.Closed))
            {
                con2.Open();
            }
        }
        public void closeConnectionEmployee()
        {
            if ((con2.State == ConnectionState.Closed))
            {
                con2.Close();
            }
        }
    }
}
