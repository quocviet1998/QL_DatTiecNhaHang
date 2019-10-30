using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using QL_DatTiecNhaHang.QLDatTiecNhaHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DatTiecNhaHang.CustomClasses
{
    public static class ExecProc
    {
        private static Session session = new BaseClass().session;
        public static XPDataView ExecKHACHHANG_GetAll()
        {
            return SprocHelper.ExecKHACHHANG_GetAllIntoDataView(session);
        }
    }
}
