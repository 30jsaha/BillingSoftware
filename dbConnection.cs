﻿using System;
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
            return ConfigurationManager.ConnectionStrings["billingFormData"].ConnectionString;
        }
    }
}
