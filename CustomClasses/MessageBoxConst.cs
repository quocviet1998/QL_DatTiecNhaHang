using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DatTiecNhaHang
{
    public static class MessageBoxConst
    {
        #region CAPTION
        public static string NOTIFICATION = "Thông báo";
        public static string ALERT = "Chú ý";
        public static string ERROR = "Lỗi";
        #endregion

        #region MESSAGE TEXT
        public static string USERNAME_REQUIRED = "Vui lòng nhập tên đăng nhập";
        public static string PASSWORD_REQUIRED = "Vui lòng nhập mật khẩu";
        public static string LOGIN_SUCCESSFULLY = "Đăng nhập thành công";
        public static string LOGIN_FAILED = "Đăng nhập thất bại. Tên đăng nhập hoặc mật khẩu không chính xác";
        public static string ACCOUNT_DISABLED = "Tài khoản bị khóa";
        public static string EXIT_CONFIRM = "Thoát khỏi chương trình? Những công việc chưa lưu sẽ bị mất";
        public static string FAILED_TO_GET_NV = "Không thể lấy được thông tin nhân viên. Vui lòng đăng nhập lại";
        public static string SAVE_LAST_ROW_FIRST = "Lưu thông tin đã thêm từ trước trước khi thêm dữ liệu mới";
        public static string ERROR_WHEN_INSERT_VALUE = "Có lỗi khi lưu dữ liệu xuống CSDL";
        public static string ERROR_WHEN_DELETE_VALUE = "Có lỗi khi xóa dữ liệu từ CSDL";
        public static string SAVED_SUCCESSFULLY = "Lưu dữ liệu thành công";
        public static string DELETED_SUCCESSFULLY = "Xóa dữ liệu thành công";
        public static string DELETE_CONFIRM  = "Xác nhận xóa dữ liệu?";
        public static string SAVE_CONFIRM  = "Xác nhận lưu dữ liệu?";
        public static string HOTEN_REQUIRED  = "Họ tên bắt buộc nhập";
        public static string NGAYSINH_REQUIRED = "Ngày sinh bắt buộc nhập";
        public static string DIACHI_REQUIRED = "Địa chỉ bắt buộc nhập";
        public static string DIENTHOAI_REQUIRED = "Số điện thoại bắt buộc nhập";

        #endregion

    }
}
