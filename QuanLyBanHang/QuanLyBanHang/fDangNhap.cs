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
using QuanLyBanHang.Data;

namespace QuanLyBanHang
{
    public partial class fDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void stackPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            var taiKhoan = DataProvider.Ins.DB.employees.Where(x => x.last_name == txbTenDangNhap.Text && x.password == txbMaKhau.Text).SingleOrDefault();
            if (taiKhoan != null)
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}