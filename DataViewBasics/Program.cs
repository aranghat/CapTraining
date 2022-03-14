using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataViewBasics
{
    internal class Program
    {
        static string conStr = "";
        static string clientName = "";

        static void Main(string[] args)
        {


            clientName = ConfigurationManager.AppSettings["strClientName"];
            Console.WriteLine("CLIENT : " + clientName);

            conStr = ConfigurationManager
                        .ConnectionStrings["myDevEcommerce"]
                        .ConnectionString;

            SqlCommand cmd      = CreateCommand("select * from products");
            SqlDataAdapter da   = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            DataView dv = new DataView(dataTable);
            dv.RowFilter = "UnitPrice <= 100";
            dv.Sort = "UnitPrice DESC";

            foreach (DataRowView row in dv)
                Console.WriteLine($"{row.Row["Name"]} {row.Row["UnitPrice"]}");

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
