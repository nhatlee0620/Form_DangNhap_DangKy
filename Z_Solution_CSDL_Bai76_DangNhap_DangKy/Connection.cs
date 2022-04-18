using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Z_Solution_CSDL_Bai76_DangNhap_DangKy
{
    public class Connection
    {
        private static string stringConnection = @"Server=LAPTOP-HB7FVB9S\SQLEXPRESS;Database=DangNhap_DangKy;User Id=sa;pwd=Nhatlee20062000@";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
