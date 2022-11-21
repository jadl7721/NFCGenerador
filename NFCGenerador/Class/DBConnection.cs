using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
//using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace NFCGenerador.Class
{
    internal class DBConnection
    {
       // private SqlCeConnection? conn;
        public static SqlConnection conn;

        public DBConnection()
        {
            ConnectToDatabase();
        }
         ~DBConnection()
        {
            conn = null;
        }

        public void Disconnect()
        {
            conn.Close();
        }

        public string ConnectToDatabase()
        {
            try
            {
                if (conn!= null)
                {
                    return "Connected";
                }
                //conn = new SqlConnection(@"Data Source=|DataDirectory|\DBNFC.mdf;Integrated Security=True");
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBNFC.mdf;Integrated Security=True");
                //conn = new SqlCeConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lanti\source\repos\NFCGenerador\NFCGenerador\DBNFC.mdf;Integrated Security=True");

                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lanti\source\repos\NFCGenerador\NFCGenerador\DBNFC.mdf;Integrated Security=True
                conn.Open();
                return "Connected";
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                conn = null;
                Console.WriteLine(e);
                return e.Message;
            }
        }
    }
}
