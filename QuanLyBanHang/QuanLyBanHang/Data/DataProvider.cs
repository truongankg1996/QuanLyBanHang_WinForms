using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class DataProvider
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=TruongAn;Initial Catalog=QuanLyBanHang;Integrated Security=True");
            return connection;
        }
    }
}
