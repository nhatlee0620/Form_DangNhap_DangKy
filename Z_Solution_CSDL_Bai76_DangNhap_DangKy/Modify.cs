using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Z_Solution_CSDL_Bai76_DangNhap_DangKy
{
    public class Modify
    {

        public Modify()
        {

        }
        SqlCommand sqlCommand; //Dùng để truy vấn các câu lệnh Insert, Update, Delete, Select 
        SqlDataReader dataReader; //Dùng để đọc dữ liệu trong bảng
        public List<TaiKhoan> TaiKhoans(string query) //Dùng để check tài khoản
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) //using: Thực thi xong thì xóa
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection); 
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1))); // cứ mỗi lần đọc là thêm vào list taiKhoans
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }

        public void Command(string query) //Dùng để đk tài khoản
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) //using: Thực thi xong thì xóa
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery(); //Thực thi câu truy vấn

                sqlConnection.Close();
            }
        }
    }
}
