using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAdoReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\CapTraining\DemoExel.xlsx" 
                                                        + ";Extended Properties=\"Excel 12.0 XML;HDR=YES;IMES=1\"");


            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from [Sheet1$]";
            cmd.Connection = con;

            var reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }
        }
    }
}
