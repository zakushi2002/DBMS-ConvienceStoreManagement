using System.Data;
using System.Data.SqlClient;

namespace ConvienceStore
{
    public class MY_DB
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-9VS351BG;Initial Catalog=StoreManagement;Integrated Security=True");
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
        SqlConnection con2 = new SqlConnection(@"Data Source=LAPTOP-9VS351BG;Initial Catalog=StoreManagement;Integrated Security=True");
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
        SqlConnection coni = new SqlConnection(@"Data Source=LAPTOP-9VS351BG;Initial Catalog=StoreManagement;Integrated Security=True");
        public SqlConnection getConnectionInvoice
        {
            get
            {
                return coni;
            }
        }
    }
}