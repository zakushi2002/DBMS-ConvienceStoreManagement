using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvienceStore
{
    class Customer
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        public bool insertCustomer(string cid, string cname, double ctotalpay, string cphone)
        {
            command = new SqlCommand("EXEC SP_AddCustomer @c ,@name ,@total ,@phone ", mydb.getConnectionManager);
            command.Parameters.Add("@c", SqlDbType.NChar).Value = cid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = cname;
            command.Parameters.Add("@total", SqlDbType.Float).Value = ctotalpay;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = cphone;
            mydb.openConnectionManager();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnectionManager();
                return true;
            }
            else
            {
                mydb.closeConnectionManager();
                return false;
            }

        }
        public bool updateCustomer(string cid, string cname, double ctotalpay, string cphone)
        {
            command = new SqlCommand("EXEC SP_UpdateCustomer @c ,@name ,@total ,@phone ", mydb.getConnectionManager);
            command.Parameters.Add("@c", SqlDbType.NChar).Value = cid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = cname;
            command.Parameters.Add("@total", SqlDbType.Float).Value = ctotalpay;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = cphone;
            mydb.openConnectionManager();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnectionManager();
                return true;
            }
            else
            {
                mydb.closeConnectionManager();
                return false;
            }
        }
        public DataTable getCustomer(string cmd)
        {
            command = new SqlCommand(cmd);
            command.Connection = mydb.getConnectionManager;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string findCustomer(string phone)
        {
            mydb.openConnectionManager();
            SqlCommand command = new SqlCommand("Select dbo.FN_FindCustomer('"+phone+"')", mydb.getConnectionManager);
            string CustomerID = (string)command.ExecuteScalar();
            mydb.closeConnectionManager();
            return CustomerID;
        }
        public int totalCustomers()
        {
            mydb.openConnectionManager();
            SqlCommand command = new SqlCommand("SELECT dbo.fn_CountCustomer() AS [NumCus]", mydb.getConnectionManager);
            int totalCustomer = (int)command.ExecuteScalar();
            mydb.closeConnectionManager();
            return totalCustomer;
        }

    }
}
