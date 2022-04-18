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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmailDK_QMK.Text;
            if(email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email đăng ký");
            }
            else
            {
                string query = "Select *from TaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    label2.ForeColor = Color.Blue;
                    //Vì chỉ có 1 email đăng ký nên list chỉ trả về 1 phần tử trong list là phần thử thứ 0
                    label2.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;                  
                }
                else
                {                  
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng ký";
                }    
            }    
        }
    }
}
