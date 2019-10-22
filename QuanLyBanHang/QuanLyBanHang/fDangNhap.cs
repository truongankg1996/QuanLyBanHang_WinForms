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

namespace QuanLyBanHang
{
    public partial class fDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txbTenDangNhap.Text == "admin" && txbMatKhau.Text == "admin" )
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}