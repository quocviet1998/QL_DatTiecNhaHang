using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DatTiecNhaHang.CustomClasses
{
    public static class Connection
    {
        public static string connectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DESKTOP-TC830C5_QLDatTiecNhaHang"].ConnectionString;
            }
        }
    }
}
