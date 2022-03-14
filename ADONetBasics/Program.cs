using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetBasics
{
    internal class Program
    {
        //static string conStr = "Integrated Security=False;Server=.\SQLEXPRESS;DataBase=ecom_temp;uid=sa;password=pass@123";
        static string conStr = "Integrated Security=SSPI;Server=.;DataBase=ecom_temp";
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Sreehari A";
            customer.Email = "sree@outlook.com";
            customer.Address = "Address 101";

            #region oldcode
            //Connection String
            //CreateCustomer(customer);


            #endregion

            //DisplayCustomers();

            // FindTotalCustomers();

            CreateOrder(1,1,1);

        }

        //1. Execute Non Query
        //INSERT, UPDATE OR DELETE
        //Returns the number of records affected
        static void CreateCustomer(Customer customer)
        {


            SqlCommand cmd = CreateCommand("insert into customers(name, email, address) values(@name, @email, @address)");
            cmd.Parameters.AddWithValue("@name", customer.Name);
            cmd.Parameters.AddWithValue("@email", customer.Email);
            cmd.Parameters.AddWithValue("@address", customer.Address);

            int retValue = cmd.ExecuteNonQuery();
            Console.WriteLine($"Total {retValue} rows where affected");

            cmd.Connection.Close();
           
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

        //2. Execute Reader
        static void DisplayCustomers()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from customers";
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($" {reader["CustomerId"]}  {reader["Name"]} {reader["Email"]}");
            }

            con.Close();
        }

        //3. Execute Scalar
        static void FindTotalCustomers()
        {
            SqlCommand cmd = CreateCommand("select count(*) from customers");
            var totalCustomers = (int)cmd.ExecuteScalar();

            Console.WriteLine("Total Number of customers = " + totalCustomers);
        }

        static void CreateOrder(int customerId,int productId,int quantity)
        {
            SqlCommand cmd   = CreateCommand("sp_CreateOrder");
            cmd.CommandType  = System.Data.CommandType.StoredProcedure;

            int orderId = 0;
            cmd.Parameters.AddWithValue("@CustomerId", customerId);
            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@Quantity", quantity);

            var outParam = cmd.Parameters.AddWithValue("@OrderId", orderId);
            outParam.Direction = System.Data.ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            Console.WriteLine("NEW ORDER REVIEVED ID : " +outParam.Value);
        }
    }
}
