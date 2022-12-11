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
    class Product
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        //PRODUCT
        public bool insertProduct(string pid, string pname, float pprice, string tid,string unitname, MemoryStream pimage)
        {
            command = new SqlCommand("EXEC SP_AddProduct @id ,@name ,@price ,@typeid ,@unitname, @image ", mydb.getConnectionManager);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = pid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = pname;
            command.Parameters.Add("@price", SqlDbType.Float).Value = pprice;
            command.Parameters.Add("@typeid", SqlDbType.NChar).Value = tid;
            command.Parameters.Add("@unitname", SqlDbType.NChar).Value = unitname;
            command.Parameters.Add("@image", SqlDbType.Image).Value = pimage.ToArray();
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
        public bool UpdateProduct(string pid, string pname, float pprice, string tid, string unitname, MemoryStream pimage)
        {
            command = new SqlCommand("EXEC SP_UpdateProduct @id ,@name ,@price ,@typeid ,@unitname, @image ", mydb.getConnectionManager);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = pid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = pname;
            command.Parameters.Add("@price", SqlDbType.Float).Value = pprice;
            command.Parameters.Add("@typeid", SqlDbType.NChar).Value = tid;
            command.Parameters.Add("@unitname", SqlDbType.NChar).Value = unitname;
            command.Parameters.Add("@image", SqlDbType.Image).Value = pimage.ToArray();
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
        public bool deleteProduct(string pid)
        {
            command = new SqlCommand("EXEC SP_DeleteProduct @id");
            command.Parameters.Add("@id", SqlDbType.NChar).Value = pid;
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

        public DataTable getProduct(string cmd)
        {
            command = new SqlCommand(cmd);
            command.Connection = mydb.getConnectionManager;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int totalCustomers()
        {
            mydb.openConnectionManager();
            SqlCommand command = new SqlCommand("SELECT dbo.fn_CountProduct() AS [NumPro]", mydb.getConnectionManager);
            int totalCustomer = (int)command.ExecuteScalar();
            mydb.closeConnectionManager();
            return totalCustomer;
        }
        //TYPE
        public bool insertType(string tid, string tname)
        {
            command = new SqlCommand("EXEC SP_AddType @tid ,@name ", mydb.getConnectionManager);
            command.Parameters.Add("@tid", SqlDbType.NChar).Value = tid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = tname;
           
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
        public bool updateType(string tid, string tname)
        {
            command = new SqlCommand("EXEC SP_UpdateType @tid ,@name ", mydb.getConnectionManager);
            command.Parameters.Add("@tid", SqlDbType.NChar).Value = tid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = tname;

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
        public bool deleteType(string tid)
        {
            command = new SqlCommand("EXEC SP_DeleteType @tid");
            command.Parameters.Add("@tid", SqlDbType.NChar).Value = tid;
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

        public DataTable getType(string cmd)
        {
            command = new SqlCommand(cmd);
            command.Connection = mydb.getConnectionManager;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Manuafacture
        public bool insertManuafacture(string mid, string mname)
        {
            command = new SqlCommand("EXEC SP_AddManuafacture @mid ,@name ", mydb.getConnectionManager);
            command.Parameters.Add("@mid", SqlDbType.NChar).Value = mid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = mname;

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
        public bool updateManuafacture(string mid, string mname)
        {
            command = new SqlCommand("EXEC SP_UpdateManuafacture @mid ,@name ", mydb.getConnectionManager);
            command.Parameters.Add("@mid", SqlDbType.NChar).Value = mid;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = mname;

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
        public bool deleteManuafacture(string mid)
        {
            command = new SqlCommand("EXEC SP_DeleteType @mid");
            command.Parameters.Add("@mid", SqlDbType.NChar).Value = mid;
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

        public DataTable getManuafacture(string cmd)
        {
            command = new SqlCommand(cmd);
            command.Connection = mydb.getConnectionManager;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Supply
        public bool insertSupply(string pid, string batchid,string mid)
        {
            command = new SqlCommand("EXEC SP_AddSupply @pid ,@batid,@mid ", mydb.getConnectionManager);
            command.Parameters.Add("@pid", SqlDbType.NChar).Value = pid;
            command.Parameters.Add("@batid", SqlDbType.NChar).Value = batchid;
            command.Parameters.Add("@mid", SqlDbType.NChar).Value = mid;
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
        public bool updateSupply(string pid, string batchid, string mid)
        {
            command = new SqlCommand("EXEC SP_UpdateSupply @pid ,@batid,@mid ", mydb.getConnectionManager);
            command.Parameters.Add("@pid", SqlDbType.NChar).Value = pid;
            command.Parameters.Add("@batid", SqlDbType.NChar).Value = batchid;
            command.Parameters.Add("@mid", SqlDbType.NChar).Value = mid;
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
        public bool deleteSupply(string pid)
        {
            command = new SqlCommand("EXEC SP_DeleteType @tid");
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

        public DataTable getSupply(string cmd)
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
