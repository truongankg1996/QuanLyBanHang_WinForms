using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QuanLyBanHang.Fuctions
{
    public partial class fDanhMucKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public fDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void fDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhMucKhachHang();
        }

        void LoadDanhMucKhachHang()
        {
            string query = "SELECT * FROM customers";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{

            //}
        }
    }
}