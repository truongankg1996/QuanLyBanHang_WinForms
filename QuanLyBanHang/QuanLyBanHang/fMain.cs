using QuanLyBanHang.Fuctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class fMain : DevExpress.XtraEditors.XtraForm
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhMucKhachHang f = new fDanhMucKhachHang();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDanhMucNhanVien f = new fDanhMucNhanVien();
            f.ShowDialog();
        }

        private void cấuHinhgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCauHinh f = new fCauHinh();
            f.ShowDialog();
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDatHang f = new fDatHang();
            f.ShowDialog();

        }
    }
}
