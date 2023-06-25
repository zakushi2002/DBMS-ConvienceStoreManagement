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
    class Invoice
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        //INVOICE
        public bool insertInvoice(string iid, string eid, string cid, DateTime idate, float itotalamount)
        {
            command = new SqlCommand("EXEC SP_AddInvoice @i ,@e ,@c ,@date ,@total ", mydb.getConnectionManager);
            command.Parameters.Add("@i", SqlDbType.NChar).Value = iid;
            command.Parameters.Add("@e", SqlDbType.NChar).Value = eid;
            command.Parameters.Add("@c", SqlDbType.NChar).Value = cid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = idate;
            command.Parameters.Add("@total", SqlDbType.NChar).Value = itotalamount;
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
        public bool updateInvoice(string iid, string eid, string cid, DateTime idate, double itotalpay)
        {
            command = new SqlCommand("EXEC SP_UpdateInvoice @i ,@e ,@c ,@date ,@total", mydb.getConnectionManager);
            command.Parameters.Add("@i", SqlDbType.NChar).Value = iid;
            command.Parameters.Add("@e", SqlDbType.NChar).Value = eid;
            command.Parameters.Add("@c", SqlDbType.NChar).Value = cid;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = idate;
            command.Parameters.Add("@total", SqlDbType.Float).Value = itotalpay;
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
        public bool updateInvoice(string iid, string eid, DateTime idate, double itotalpay)
        {
            command = new SqlCommand("EXEC SP_UpdateInvoiceNotCustomer @i ,@e,@date ,@total", mydb.getConnectionManager);
            command.Parameters.Add("@i", SqlDbType.NChar).Value = iid;
            command.Parameters.Add("@e", SqlDbType.NChar).Value = eid;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = idate;
            command.Parameters.Add("@total", SqlDbType.Float).Value = itotalpay;
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
        public bool deleteInvoice(string iid)
        {
            command = new SqlCommand("EXEC SP_DeleteInvoice @i");
            command.Parameters.Add("@i", SqlDbType.NChar).Value = iid;
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
        public DataTable getInvoice(string cmd)
        {
            command = new SqlCommand(cmd);
            command.Connection = mydb.getConnectionManager;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public double totalPay(string iid)
        {
            mydb.openConnectionManager();
            command = new SqlCommand("SELECT dbo.FN_GetTotalPay('"+iid+"')", mydb.getConnectionManager);
            double totalPay = (double)command.ExecuteScalar();
            mydb.closeConnectionManager();
            return totalPay;
        }
        //DETAIL
        public bool insertDetail(string iid,string pid,int damount, double dprice)
        {
            command = new SqlCommand("EXEC SP_AddDetail @id,@pid,@amount,@price", mydb.getConnectionManager);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = iid;
            command.Parameters.Add("@pid", SqlDbType.NChar).Value = pid;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = damount;
            command.Parameters.Add("@price", SqlDbType.Float).Value = dprice;
            
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
        public bool updateDetail(string iid, string pid, double dprice, int damount)
        {
            command = new SqlCommand("EXEC SP_UpdateDetail @id ,@pid ,@price ,@amount", mydb.getConnectionManager);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = iid;
            command.Parameters.Add("@pid", SqlDbType.NChar).Value = pid;
            command.Parameters.Add("@price", SqlDbType.Float).Value = dprice;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = damount;
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
        public bool deleteDetail(string iid, string pid)
        {
            command = new SqlCommand("EXEC SP_DeleteDetail @id, @pid", mydb.getConnectionManager);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = iid;
            command.Parameters.Add("@pid", SqlDbType.NChar).Value = pid;
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

        public DataTable getDetail (string cmd)
        {
            command = new SqlCommand(cmd);
            command.Connection = mydb.getConnectionManager;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
