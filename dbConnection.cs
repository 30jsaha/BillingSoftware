using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace BillingSoftware
{
    class dbConnection
    {
        public static string GetConnectionString()
        {
            // return ConfigurationManager.ConnectionStrings["billingFormData"].ConnectionString;
            string db_name = Constants.dbName;
            return "Data Source=ADZGURU\\SQLEXPRESS;Initial Catalog="+db_name+";Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        }
        public static string GetCommonDBConnectionString()
        {
            // return ConfigurationManager.ConnectionStrings["billingFormData"].ConnectionString;
            string db_name = "accountsGeneralData";
            return "Data Source=ADZGURU\\SQLEXPRESS;Initial Catalog="+db_name+";Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        }
        public static void ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                // Perform database operations
            }
        }
    }
}
