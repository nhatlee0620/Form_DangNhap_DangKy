using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Z_Solution_CSDL_Bai76_DangNhap_DangKy
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool checkAcccount(string ac) //Check mật khẩu và tên tài khoản
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em) //Check Email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$"); //w=a-zA-Z0-9_.
        }

        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTaiKhoanDK.Text;
            string matkhau = txtMatKhauDK.Text;
            string xnmatkhau = txtXacNhanMKDK.Text;
            string email = txtEmailDK.Text;

            if(!checkAcccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự với các ký tự chữ và số, chữ hoa và chữ thường");
                return;
            }
            if(!checkAcccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6-24 ký tự với các ký tự chữ và số, chữ hoa và chữ thường");
                return;
            }
            if(xnmatkhau!=matkhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }    
            if(!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                return;
            }    
            if(modify.TaiKhoans("Select *from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký Email khác");
                return;
            }  
            //Vì ở đây chọn tên tài khoản là khóa chính rồi cho nên lúc Insert thì tên tài khoản không được trùng nhau
            //Cho nên khỏi cần dùng điều kiện kiểm tra tài khoản
            try
            {
                string query = "Insert into TaiKhoan values ('"+tentk+"','"+matkhau+"','"+email+"')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký thành công! Bạn có muốn quay về Đăng Nhập?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tên tài khoản đã được đăng ký! Vui lòng đăng ký tên tài khoản khác");
            }
        }
    }
}
