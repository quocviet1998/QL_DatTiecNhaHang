using DevExpress.Xpo;
using QL_DatTiecNhaHang.QLDatTiecNhaHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DatTiecNhaHang.CustomClasses
{
    public class QLNguoiDung
    {
        Session session = new Session();

        public QLNguoiDung()
        {
            session.ConnectionString = System.Configuration.ConfigurationManager.
    ConnectionStrings["DESKTOP-TC830C5_QLDatTiecNhaHang"].ConnectionString;
        }

        public int CheckUser(string _username, string _password)
        {
            var result = SprocHelper.ExecDANGNHAP(session, _username, _password);
            return int.Parse(result.ResultSet[0].Rows[0].Values[0].ToString());
        }
    }
}
