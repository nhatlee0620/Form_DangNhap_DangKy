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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đăng xuất không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dangnhap = new DangNhap();
                dangnhap.ShowDialog();
            }    
        }
    }
}
