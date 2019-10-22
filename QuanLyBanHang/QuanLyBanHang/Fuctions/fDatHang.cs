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
    public partial class fDatHang : DevExpress.XtraEditors.XtraForm
    {
        public fDatHang()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHangDataSet);

        }

        private void fDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter.Fill(this.quanLyBanHangDataSet.order_details);
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.quanLyBanHangDataSet.orders);

        }
    }
}