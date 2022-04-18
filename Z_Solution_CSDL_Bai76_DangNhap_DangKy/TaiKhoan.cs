using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_Solution_CSDL_Bai76_DangNhap_DangKy
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
