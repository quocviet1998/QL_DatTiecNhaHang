using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DatTiecNhaHang.CustomClasses.DTOs
{
    public class NHANVIEN_DTO
    {
        public int IdNV { get; set; }
        public string HoTenNV { get; set; }
        public DateTime NgaySinhNV { get; set; }
        public bool GioiTinhNV { get; set; }
        public string DiaChiNV { get; set; }
        public string DienThoaiNV { get; set; }
        public string GhiChuNV { get; set; }
        public string TenBP { get; set; }
    }
}
