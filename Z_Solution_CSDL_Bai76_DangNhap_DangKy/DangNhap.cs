using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Solution_CSDL_Bai76_DangNhap_DangKy
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void lblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoanDangNhap.Text;
            string matkhau = txtMatKhauDangNhap.Text;
            if(tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if(matkhau.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "Select *from TaiKhoan where TenTaiKhoan = '" + tentk + "' " +
                    "and MatKhau = '" + matkhau + "'"; ;
                if(modify.TaiKhoans(query).Count!=0)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide(); // Giấu cái form đăng nhập đi để vào cái home
                    Home home = new Home();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }    
        }
    }
}
