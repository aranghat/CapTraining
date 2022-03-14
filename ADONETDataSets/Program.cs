using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDataSets
{
    internal class Program
    {
        static string conStr = "Integrated Security=SSPI;Server=.;DataBase=ecom_temp";
        static DataTable dt;

        static void Main(string[] args)
        {
            dt = FetchCustomers();

            Display(dt);

            CreateNewCustomer();
            UpdateCustomer();
           

            Console.WriteLine("------------------------------------------------");
            Display(dt);

            UpdateCustomersDataTable(dt);

            DeleteCustomer();

            UpdateCustomersDataTable(dt);
        }

        static void CreateNewCustomer()
        {
            DataRow newCustomerRow = dt.NewRow();
            newCustomerRow["Name"] = "Jhon";
            newCustomerRow["Email"] = "jhon@gmail.com";
            newCustomerRow["Address"] = "California";

            dt.Rows.Add(newCustomerRow);

        }

        static void DeleteCustomer()
        {
            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["CustomerId"] == 1004)
                {
                    row.Delete();
                    break;
                }
                   
            }
        }

        static void UpdateCustomer()
        {
            foreach (DataRow row in dt.Rows)
            {
                if(row["Name"] == "Sree")
                    row["Name"] = "UPDATED " + row["Name"];
            }

            //DataRow updatedRow = dt.Rows[0];
           
        }

        static void UpdateCustomersDataTable(DataTable dt)
        {
            SqlCommand cmd          = CreateCommand("insert into customers(name,email,address) values(@name,@email,@address)");
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50, "Name");
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50, "Email");
            cmd.Parameters.Add("@address", SqlDbType.VarChar, 50, "Address");

            SqlCommand updateUpdateCmd = CreateCommand("update customers set Name=@name,Email=@email,Address=@address where customerid = @customerid");
            updateUpdateCmd.Parameters.Add("@name", SqlDbType.VarChar, 50, "Name");
            updateUpdateCmd.Parameters.Add("@email", SqlDbType.VarChar, 50, "Email");
            updateUpdateCmd.Parameters.Add("@address", SqlDbType.VarChar, 50, "Address");
            updateUpdateCmd.Parameters.Add("@customerid", SqlDbType.Int,5, "CustomerId");

            SqlCommand deleteCmd = CreateCommand("delete from customers where customerid = @customerid");
            var deleteParam = deleteCmd.Parameters.Add("@customerid", SqlDbType.Int, 5, "CustomerId");
           

            SqlDataAdapter adapter  = new SqlDataAdapter(cmd);
            adapter.InsertCommand   = cmd;
            adapter.UpdateCommand   = updateUpdateCmd;
            adapter.DeleteCommand   = deleteCmd;

            adapter.Update(dt);
            
        }

        static DataTable FetchCustomers()
        {
            SqlCommand cmd          = CreateCommand("select * from customers");
            SqlDataAdapter adapter  = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        static void Display(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + "\t");

                Console.WriteLine();
            }
        }

        static SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            return con;
        }

        static SqlCommand CreateCommand(string text)
        {
            var con = CreateConnection();
            SqlCommand cmd = new SqlCommand(text, con);

            return cmd;
        }
    }
}
