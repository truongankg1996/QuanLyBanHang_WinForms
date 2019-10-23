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
    public partial class fDatHang : DevExpress.XtraEditors.XtraForm
    {
        public fDatHang()
        {
            InitializeComponent();
        }
        string connectionSTR = "Data Source=TruongAn;Initial Catalog=QuanLyBanHang;Integrated Security=True";


        private void fDatHang_Load(object sender, EventArgs e)
        {

            LoadDanhSachNhanVien();
        }

        void LoadDanhSachNhanVien()
        {
            string query = String.Format("SELECT * FROM employees");

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDataSet.employees);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in quanLyBanHangDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listEmployees.Add(key, value);
                        }
                        cbEmployee.DataSource = new BindingSource(listEmployees, null);
                        cbEmployee.DisplayMember = "Value";
                        cbEmployee.ValueMember = "Key";

                        connection.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                }
            }
        }
    }
}