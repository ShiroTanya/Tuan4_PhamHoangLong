using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tuan4_PhamHoangLong.Models
{
    public class ThongTinKhachHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int makh { get; set; }

        [Display(Name = "Họ và tên")]
        public string hoten { get; set; }

        [Display(Name = "Tên đăng nhập")]
        public string tendangnhap { get; set; }
        [Display(Name = "Mật khẩu")]
        public string matkhau { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Địa chỉ")]
        public string diachi { get; set; }
        [Display(Name = "Số điện thoại")]
        public string dienthoai { get; set; }
        public DateTime ngaysinh { get; set; }

    }
}