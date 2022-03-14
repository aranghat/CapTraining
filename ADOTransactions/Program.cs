using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTransactions
{
    internal class Program
    {
        static string conStr = "Integrated Security=SSPI;Server=.;DataBase=ecom_temp";

        static void Main(string[] args)
        {

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                var trans = con.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.Transaction = trans;
                    cmd.CommandText = "insert into products(Name,TotalAvailableQuantity,UnitPrice) VALUES('Test Item',10,10.5);";
                    int retValue = cmd.ExecuteNonQuery();

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                }
                
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
