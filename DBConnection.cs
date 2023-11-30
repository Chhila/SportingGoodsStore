using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingGoodsStore
{
    internal class DBConnection
    {
        public static string StaffID { get; set; }
        public static SqlConnection DataCon { get; set; }

        public static void ConnectionDB(string ip, string dbName, string user, string password) /*Method*/
        {
            string connectionString = "Server=" + ip + ";Database=" + dbName + ";User ID=" + user + ";Password=" + password;
            DataCon = new SqlConnection(connectionString);
            DataCon.Open();
        }
        public static void ConnectionDB(string ip, string dbName)
        {
            string connectionString = "Server=" + ip + ";Database=" + dbName + ";Trusted_Connection=True";
            DataCon = new SqlConnection(connectionString);
            DataCon.Open();
        }
    }
}
