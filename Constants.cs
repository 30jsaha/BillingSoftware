using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    public static class Constants
    {
        //This [item_id] is just for testing, never used
        public const int item_id = 0;
        public const int customerBtype = 1;
        public const int customerItype = 2;
        public const int companyStartId = 1001;
        public const int ADMIN = 7;
        public const int STAFF = 6;
        public static string dbName = "billingFormData";
        public static string defaultCompanyDbNamePrefix = "accountsData";
        public static string defaultUserName = "User";
        public static int selectedCompanyId = 0;
        public static bool isLoggedIn = false;
        public static int LoggedInUserId = 0;
        public static int LoggedInUserType = 0;
    }
}
