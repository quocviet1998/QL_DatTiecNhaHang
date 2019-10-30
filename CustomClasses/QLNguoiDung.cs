using DevExpress.Xpo;
using QL_DatTiecNhaHang.CustomClasses.DTOs;
using QL_DatTiecNhaHang.QLDatTiecNhaHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DatTiecNhaHang.CustomClasses
{
    public class QLNguoiDung : BaseClass//<NHANVIEN_DTO, object[]>
    {
        #region Variables
        protected string username { get; set; }
        protected string password { get; set; }
        protected bool isActive { get; set; }
        public int IdNV { get; set; }
        #endregion

        public QLNguoiDung(string username, string password)
        {
            getSession();
            this.username = username;
            this.password = password;
        }

        public QLNguoiDung()
        {
            getSession();
        }

        public int CheckUser()
        {
            var result = SprocHelper.ExecDANGNHAP(session, username, password);
            
            var temp = int.Parse(result.ResultSet[0].Rows[0].Values[0].ToString());

            if(temp == 1)
                IdNV = int.Parse(result.ResultSet[0].Rows[0].Values[1].ToString());
            return temp;
        }

        public NHANVIEN_DTO getNhanVienById(int IdNV)
        {
            NHANVIEN_DTO dto = new NHANVIEN_DTO();
            var result = SprocHelper.ExecNHANVIEN_ById(session, IdNV);
            var values = result.ResultSet[0].Rows[0].Values;
            try
            {
                dto.IdNV = int.Parse(values[0].ToString());
                dto.HoTenNV = values[1].ToString();
                dto.NgaySinhNV = DateTime.Parse(values[2].ToString());
                dto.GioiTinhNV = Boolean.Parse(values[3].ToString());
                dto.DiaChiNV = values[4].ToString();
                dto.DienThoaiNV = values[5].ToString();
                dto.GhiChuNV = values[6] == null ? null : values[6].ToString();
                dto.TenBP = values[7].ToString();
                return dto;
            }
            catch(Exception e)
            {
                throw e;
            }
        }


        #region Private functions
        
        #endregion
    }
}
