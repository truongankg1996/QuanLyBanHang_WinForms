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

namespace QuanLyBanHang.Fuctions
{
    public partial class fDanhMucNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public fDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHangDataSet);

        }

        private void fDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.quanLyBanHangDataSet.employees);
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.quanLyBanHangDataSet.customers);

        }
    }
}