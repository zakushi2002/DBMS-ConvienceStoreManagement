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
    public class Employee
    {
        MY_DB mydb = new MY_DB();
        SqlCommand command;
        public bool insertEmployee(string id, string name, DateTime date, string gender, string phone, string address, string position, double salary, MemoryStream image)
        {
            command = new SqlCommand("EXEC SP_AddEmployee @id,@name,@date,@gender,@phone,@address,@position,@salary,@image", mydb.getConnectionManager);
            command.Parameters.Add("@id",SqlDbType.NChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NChar).Value = address;
            command.Parameters.Add("@position", SqlDbType.NChar).Value = position;
            command.Parameters.Add("@salary", SqlDbType.Float).Value = salary;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();
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
        public bool updateEmployee(string id, string name, DateTime date, string gender, string phone, string address, string position, double salary, MemoryStream image)
        {
            command = new SqlCommand("EXEC SP_UpdateEmployee @id,@name,@date,@gender,@phone,@address,@position,@salary,@image", mydb.getConnectionManager);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NChar).Value = address;
            command.Parameters.Add("@position", SqlDbType.NChar).Value = position;
            command.Parameters.Add("@salary", SqlDbType.Float).Value = salary;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();
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
        public bool deleteEmployee(string id)
        {
            command = new SqlCommand("EXEC SP_DeleteEmployee @id");
            command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
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
        public DataTable getEmployee(string cmd)
        {
            command = new SqlCommand(cmd);
            command.Connection = mydb.getConnectionManager;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int totalEmployees()
        {
            mydb.openConnectionManager();
            SqlCommand command = new SqlCommand("SELECT dbo.fn_CountEmployee() AS [Num]", mydb.getConnectionManager);
            int totalMale = (int)command.ExecuteScalar();
            mydb.closeConnectionManager();
            return totalMale;
        }

    }
}
