namespace QuanLyBanHang.Fuctions
{
    partial class fCauHinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label keyLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label valueLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.configsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCauHinh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            keyLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHinh)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new System.Drawing.Point(27, 7);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new System.Drawing.Size(43, 21);
            keyLabel.TabIndex = 0;
            keyLabel.Text = "Key:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(254, 7);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(31, 21);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(13, 43);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(57, 21);
            valueLabel.TabIndex = 5;
            valueLabel.Text = "Value:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(valueLabel);
            this.panel1.Controls.Add(this.valueTextBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(keyLabel);
            this.panel1.Controls.Add(this.keyTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 94);
            this.panel1.TabIndex = 0;
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configsBindingSource, "value", true));
            this.valueTextBox.Location = new System.Drawing.Point(74, 40);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(137, 28);
            this.valueTextBox.TabIndex = 6;
            // 
            // configsBindingSource
            // 
            this.configsBindingSource.DataMember = "configs";
            this.configsBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(291, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 28);
            this.idTextBox.TabIndex = 5;
            // 
            // keyTextBox
            // 
            this.keyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configsBindingSource, "key", true));
            this.keyTextBox.Location = new System.Drawing.Point(74, 4);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(137, 28);
            this.keyTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvCauHinh);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 303);
            this.panel2.TabIndex = 1;
            // 
            // dgvCauHinh
            // 
            this.dgvCauHinh.AutoGenerateColumns = false;
            this.dgvCauHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvCauHinh.DataSource = this.configsBindingSource;
            this.dgvCauHinh.Location = new System.Drawing.Point(0, 3);
            this.dgvCauHinh.Name = "dgvCauHinh";
            this.dgvCauHinh.Size = new System.Drawing.Size(632, 297);
            this.dgvCauHinh.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "key";
            this.dataGridViewTextBoxColumn2.HeaderText = "key";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "value";
            this.dataGridViewTextBoxColumn3.HeaderText = "value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btThem);
            this.panel6.Controls.Add(this.btSua);
            this.panel6.Controls.Add(this.btXoa);
            this.panel6.Controls.Add(this.btThoat);
            this.panel6.Location = new System.Drawing.Point(19, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(628, 46);
            this.panel6.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(179, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(107, 41);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(292, 3);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(107, 41);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(405, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(107, 41);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(518, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(107, 41);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // fCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 455);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fCauHinh";
            this.Text = "Cấu Hình";
            this.Load += new System.EventHandler(this.fCauHinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHinh)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource configsBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.DataGridView dgvCauHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}