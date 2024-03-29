﻿using System;
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
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Fuctions
{
    public partial class fCauHinh : DevExpress.XtraEditors.XtraForm
    {
        public fCauHinh()
        {
            InitializeComponent();
        }
        //Tạo kết nối tới DB

        private void fCauHinh_Load(object sender, EventArgs e)
        {
            LoadCauHinh();
        }
         private void LoadCauHinh()
        {
            string query = "SELECT * FROM configs";

            //SqlConnection sqlConnection = DataProvider.GetSqlConnection();
                using (SqlCommand command = new SqlCommand(query, DataProvider.GetSqlConnection()))
                {
                    try
                    {
                    DataProvider.GetSqlConnection().Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDataSet.configs);

                        // Hiển thị dữ liệu
                        configsBindingSource.DataSource = quanLyBanHangDataSet.configs;
                        dgvCauHinh.Refresh();

                    DataProvider.GetSqlConnection().Close();

                        LoadCauHinh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(keyTextBox.Text) || string.IsNullOrEmpty(valueTextBox.Text))
            //{
            //    MessageBox.Show("Vui lòng kiểm tra dữ liệu đã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //string query = @"INSERT INTO   configs ([key], [value]) VALUES (@key, @value)";

            //using (DataProvider.GetSqlConnection())
            //{
            //    using (SqlCommand command = new SqlCommand(query, DataProvider.GetSqlConnection()))
            //    {
            //        try
            //        {
            //            DataProvider.GetSqlConnection().Open();

            //            command.CommandType = CommandType.Text;
            //            command.Parameters.AddWithValue("@key", keyTextBox.Text);
            //            command.Parameters.AddWithValue("@value", valueTextBox.Text);

            //            int efffect = command.ExecuteNonQuery();
            //            DataProvider.GetSqlConnection().Close();

            //            LoadCauHinh();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //            throw;
            //        }
            //    }
            //}
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(keyTextBox.Text) || string.IsNullOrEmpty(valueTextBox.Text))
            //{
            //    MessageBox.Show("Vui lòng kiểm tra dữ liệu đã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //string query = @"UPDATE configs SET [key] = @key, [value] = @value WHERE id =@id";

            //using (DataProvider.GetSqlConnection())
            //{
            //    using (SqlCommand command = new SqlCommand(query, DataProvider.GetSqlConnection()))
            //    {
            //        try
            //        {
            //            DataProvider.GetSqlConnection().Open();

            //            command.CommandType = CommandType.Text;
            //            command.Parameters.AddWithValue("@id", idTextBox.Text);
            //            command.Parameters.AddWithValue("@key", keyTextBox.Text);
            //            command.Parameters.AddWithValue("@value", valueTextBox.Text);

            //            int efffect = command.ExecuteNonQuery();
            //            DataProvider.GetSqlConnection().Close();

            //            LoadCauHinh();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //            throw;
            //        }
            //    }
            //}
        }
    }
}