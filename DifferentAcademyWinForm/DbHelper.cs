using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentAcademyWinForm {
    public static class DbHelper {
        public static string CnnVal(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            
        }

        public enum AccountType {
            User,
            Admin
        }
    }
}
