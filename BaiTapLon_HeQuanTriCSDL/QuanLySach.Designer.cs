namespace BaiTapLon_HeQuanTriCSDL
{
    partial class listbox_Name
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
            this.dataGridView_QLSACH_Sach = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSACH_Sach_DataSet = new BaiTapLon_HeQuanTriCSDL.QLSACH_Sach_DataSet();
            this.sachTableAdapter = new BaiTapLon_HeQuanTriCSDL.QLSACH_Sach_DataSetTableAdapters.SachTableAdapter();
            this.textBox_MaSach_inQuanLySach = new System.Windows.Forms.TextBox();
            this.textBox_TenSach_inQuanLySach = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgayXuatBan = new System.Windows.Forms.DateTimePicker();
            this.label_NgayXuatBan = new System.Windows.Forms.Label();
            this.comboBox_MaTheLoai = new System.Windows.Forms.ComboBox();
            this.comboBox_NhaXuatBan = new System.Windows.Forms.ComboBox();
            this.textBox_SoTrang = new System.Windows.Forms.TextBox();
            this.button_ThemSach = new System.Windows.Forms.Button();
            this.label_SoTrang = new System.Windows.Forms.Label();
            this.label_NhaXuatBan = new System.Windows.Forms.Label();
            this.label_TheLoai = new System.Windows.Forms.Label();
            this.label_NgayXuatBan_inQuanLySach = new System.Windows.Forms.Label();
            this.label_TenSach = new System.Windows.Forms.Label();
            this.label_MaSach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLSACH_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSACH_Sach_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_QLSACH_Sach
            // 
            this.dataGridView_QLSACH_Sach.AutoGenerateColumns = false;
            this.dataGridView_QLSACH_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLSACH_Sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.ngayXBDataGridViewTextBoxColumn,
            this.maTLDataGridViewTextBoxColumn,
            this.maXBDataGridViewTextBoxColumn,
            this.soTrangDataGridViewTextBoxColumn,
            this.giaSachDataGridViewTextBoxColumn,
            this.sLTonDataGridViewTextBoxColumn});
            this.dataGridView_QLSACH_Sach.DataSource = this.sachBindingSource;
            this.dataGridView_QLSACH_Sach.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_QLSACH_Sach.Name = "dataGridView_QLSACH_Sach";
            this.dataGridView_QLSACH_Sach.RowHeadersWidth = 62;
            this.dataGridView_QLSACH_Sach.RowTemplate.Height = 28;
            this.dataGridView_QLSACH_Sach.Size = new System.Drawing.Size(1264, 506);
            this.dataGridView_QLSACH_Sach.TabIndex = 0;
            this.dataGridView_QLSACH_Sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QLSACH_Sach_CellContentClick);
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.maSachDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tenSachDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayXBDataGridViewTextBoxColumn
            // 
            this.ngayXBDataGridViewTextBoxColumn.DataPropertyName = "NgayXB";
            this.ngayXBDataGridViewTextBoxColumn.HeaderText = "Ngày xuất bản";
            this.ngayXBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayXBDataGridViewTextBoxColumn.Name = "ngayXBDataGridViewTextBoxColumn";
            this.ngayXBDataGridViewTextBoxColumn.Width = 150;
            // 
            // maTLDataGridViewTextBoxColumn
            // 
            this.maTLDataGridViewTextBoxColumn.DataPropertyName = "MaTL";
            this.maTLDataGridViewTextBoxColumn.HeaderText = "Mã thể loại";
            this.maTLDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTLDataGridViewTextBoxColumn.Name = "maTLDataGridViewTextBoxColumn";
            this.maTLDataGridViewTextBoxColumn.Width = 150;
            // 
            // maXBDataGridViewTextBoxColumn
            // 
            this.maXBDataGridViewTextBoxColumn.DataPropertyName = "MaXB";
            this.maXBDataGridViewTextBoxColumn.HeaderText = "Mã xuất bản";
            this.maXBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maXBDataGridViewTextBoxColumn.Name = "maXBDataGridViewTextBoxColumn";
            this.maXBDataGridViewTextBoxColumn.Width = 150;
            // 
            // soTrangDataGridViewTextBoxColumn
            // 
            this.soTrangDataGridViewTextBoxColumn.DataPropertyName = "SoTrang";
            this.soTrangDataGridViewTextBoxColumn.HeaderText = "Số trang";
            this.soTrangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soTrangDataGridViewTextBoxColumn.Name = "soTrangDataGridViewTextBoxColumn";
            this.soTrangDataGridViewTextBoxColumn.Width = 150;
            // 
            // giaSachDataGridViewTextBoxColumn
            // 
            this.giaSachDataGridViewTextBoxColumn.DataPropertyName = "GiaSach";
            this.giaSachDataGridViewTextBoxColumn.HeaderText = "Giá sách";
            this.giaSachDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.giaSachDataGridViewTextBoxColumn.Name = "giaSachDataGridViewTextBoxColumn";
            this.giaSachDataGridViewTextBoxColumn.Width = 150;
            // 
            // sLTonDataGridViewTextBoxColumn
            // 
            this.sLTonDataGridViewTextBoxColumn.DataPropertyName = "SLTon";
            this.sLTonDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn";
            this.sLTonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sLTonDataGridViewTextBoxColumn.Name = "sLTonDataGridViewTextBoxColumn";
            this.sLTonDataGridViewTextBoxColumn.Width = 150;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLSACH_Sach_DataSet;
            // 
            // qLSACH_Sach_DataSet
            // 
            this.qLSACH_Sach_DataSet.DataSetName = "QLSACH_Sach_DataSet";
            this.qLSACH_Sach_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_MaSach_inQuanLySach
            // 
            this.textBox_MaSach_inQuanLySach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox_MaSach_inQuanLySach.Location = new System.Drawing.Point(103, 576);
            this.textBox_MaSach_inQuanLySach.Name = "textBox_MaSach_inQuanLySach";
            this.textBox_MaSach_inQuanLySach.Size = new System.Drawing.Size(125, 28);
            this.textBox_MaSach_inQuanLySach.TabIndex = 1;
            this.textBox_MaSach_inQuanLySach.Text = "TEST";
            // 
            // textBox_TenSach_inQuanLySach
            // 
            this.textBox_TenSach_inQuanLySach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox_TenSach_inQuanLySach.Location = new System.Drawing.Point(234, 576);
            this.textBox_TenSach_inQuanLySach.Name = "textBox_TenSach_inQuanLySach";
            this.textBox_TenSach_inQuanLySach.Size = new System.Drawing.Size(150, 28);
            this.textBox_TenSach_inQuanLySach.TabIndex = 2;
            this.textBox_TenSach_inQuanLySach.Text = "TEST";
            // 
            // dateTimePicker_NgayXuatBan
            // 
            this.dateTimePicker_NgayXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker_NgayXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayXuatBan.Location = new System.Drawing.Point(390, 576);
            this.dateTimePicker_NgayXuatBan.Name = "dateTimePicker_NgayXuatBan";
            this.dateTimePicker_NgayXuatBan.Size = new System.Drawing.Size(138, 28);
            this.dateTimePicker_NgayXuatBan.TabIndex = 3;
            // 
            // label_NgayXuatBan
            // 
            this.label_NgayXuatBan.AutoSize = true;
            this.label_NgayXuatBan.Location = new System.Drawing.Point(340, 542);
            this.label_NgayXuatBan.Name = "label_NgayXuatBan";
            this.label_NgayXuatBan.Size = new System.Drawing.Size(0, 20);
            this.label_NgayXuatBan.TabIndex = 4;
            // 
            // comboBox_MaTheLoai
            // 
            this.comboBox_MaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_MaTheLoai.FormattingEnabled = true;
            this.comboBox_MaTheLoai.Location = new System.Drawing.Point(534, 576);
            this.comboBox_MaTheLoai.Name = "comboBox_MaTheLoai";
            this.comboBox_MaTheLoai.Size = new System.Drawing.Size(177, 28);
            this.comboBox_MaTheLoai.TabIndex = 5;
            this.comboBox_MaTheLoai.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaTheLoai_SelectedIndexChanged);
            // 
            // comboBox_NhaXuatBan
            // 
            this.comboBox_NhaXuatBan.FormattingEnabled = true;
            this.comboBox_NhaXuatBan.Location = new System.Drawing.Point(717, 576);
            this.comboBox_NhaXuatBan.Name = "comboBox_NhaXuatBan";
            this.comboBox_NhaXuatBan.Size = new System.Drawing.Size(242, 28);
            this.comboBox_NhaXuatBan.TabIndex = 6;
            this.comboBox_NhaXuatBan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_SoTrang
            // 
            this.textBox_SoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoTrang.Location = new System.Drawing.Point(965, 576);
            this.textBox_SoTrang.Name = "textBox_SoTrang";
            this.textBox_SoTrang.Size = new System.Drawing.Size(99, 28);
            this.textBox_SoTrang.TabIndex = 7;
            this.textBox_SoTrang.Text = "123";
            this.textBox_SoTrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_ThemSach
            // 
            this.button_ThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemSach.ForeColor = System.Drawing.Color.Red;
            this.button_ThemSach.Location = new System.Drawing.Point(1114, 542);
            this.button_ThemSach.Name = "button_ThemSach";
            this.button_ThemSach.Size = new System.Drawing.Size(162, 62);
            this.button_ThemSach.TabIndex = 10;
            this.button_ThemSach.Text = "THÊM SÁCH";
            this.button_ThemSach.UseVisualStyleBackColor = true;
            this.button_ThemSach.Click += new System.EventHandler(this.button_ThemSach_Click);
            // 
            // label_SoTrang
            // 
            this.label_SoTrang.AutoSize = true;
            this.label_SoTrang.Location = new System.Drawing.Point(977, 553);
            this.label_SoTrang.Name = "label_SoTrang";
            this.label_SoTrang.Size = new System.Drawing.Size(70, 20);
            this.label_SoTrang.TabIndex = 11;
            this.label_SoTrang.Text = "Số trang";
            // 
            // label_NhaXuatBan
            // 
            this.label_NhaXuatBan.AutoSize = true;
            this.label_NhaXuatBan.Location = new System.Drawing.Point(786, 553);
            this.label_NhaXuatBan.Name = "label_NhaXuatBan";
            this.label_NhaXuatBan.Size = new System.Drawing.Size(103, 20);
            this.label_NhaXuatBan.TabIndex = 12;
            this.label_NhaXuatBan.Text = "Nhà xuất bản";
            // 
            // label_TheLoai
            // 
            this.label_TheLoai.AutoSize = true;
            this.label_TheLoai.Location = new System.Drawing.Point(587, 553);
            this.label_TheLoai.Name = "label_TheLoai";
            this.label_TheLoai.Size = new System.Drawing.Size(64, 20);
            this.label_TheLoai.TabIndex = 13;
            this.label_TheLoai.Text = "Thể loại";
            // 
            // label_NgayXuatBan_inQuanLySach
            // 
            this.label_NgayXuatBan_inQuanLySach.AutoSize = true;
            this.label_NgayXuatBan_inQuanLySach.Location = new System.Drawing.Point(406, 553);
            this.label_NgayXuatBan_inQuanLySach.Name = "label_NgayXuatBan_inQuanLySach";
            this.label_NgayXuatBan_inQuanLySach.Size = new System.Drawing.Size(110, 20);
            this.label_NgayXuatBan_inQuanLySach.TabIndex = 14;
            this.label_NgayXuatBan_inQuanLySach.Text = "Ngày xuất bản";
            // 
            // label_TenSach
            // 
            this.label_TenSach.AutoSize = true;
            this.label_TenSach.Location = new System.Drawing.Point(266, 553);
            this.label_TenSach.Name = "label_TenSach";
            this.label_TenSach.Size = new System.Drawing.Size(74, 20);
            this.label_TenSach.TabIndex = 15;
            this.label_TenSach.Text = "Tên sách";
            // 
            // label_MaSach
            // 
            this.label_MaSach.AutoSize = true;
            this.label_MaSach.Location = new System.Drawing.Point(138, 553);
            this.label_MaSach.Name = "label_MaSach";
            this.label_MaSach.Size = new System.Drawing.Size(69, 20);
            this.label_MaSach.TabIndex = 16;
            this.label_MaSach.Text = "Mã sách";
            // 
            // listbox_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 616);
            this.Controls.Add(this.label_MaSach);
            this.Controls.Add(this.label_TenSach);
            this.Controls.Add(this.label_NgayXuatBan_inQuanLySach);
            this.Controls.Add(this.label_TheLoai);
            this.Controls.Add(this.label_NhaXuatBan);
            this.Controls.Add(this.label_SoTrang);
            this.Controls.Add(this.button_ThemSach);
            this.Controls.Add(this.textBox_SoTrang);
            this.Controls.Add(this.comboBox_NhaXuatBan);
            this.Controls.Add(this.comboBox_MaTheLoai);
            this.Controls.Add(this.label_NgayXuatBan);
            this.Controls.Add(this.dateTimePicker_NgayXuatBan);
            this.Controls.Add(this.textBox_TenSach_inQuanLySach);
            this.Controls.Add(this.textBox_MaSach_inQuanLySach);
            this.Controls.Add(this.dataGridView_QLSACH_Sach);
            this.Name = "listbox_Name";
            this.Text = "Quản lý kho sách";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLSACH_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSACH_Sach_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_QLSACH_Sach;
        private QLSACH_Sach_DataSet qLSACH_Sach_DataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLSACH_Sach_DataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_MaSach_inQuanLySach;
        private System.Windows.Forms.TextBox textBox_TenSach_inQuanLySach;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayXuatBan;
        private System.Windows.Forms.Label label_NgayXuatBan;
        private System.Windows.Forms.ComboBox comboBox_MaTheLoai;
        private System.Windows.Forms.ComboBox comboBox_NhaXuatBan;
        private System.Windows.Forms.TextBox textBox_SoTrang;
        private System.Windows.Forms.Button button_ThemSach;
        private System.Windows.Forms.Label label_SoTrang;
        private System.Windows.Forms.Label label_NhaXuatBan;
        private System.Windows.Forms.Label label_TheLoai;
        private System.Windows.Forms.Label label_NgayXuatBan_inQuanLySach;
        private System.Windows.Forms.Label label_TenSach;
        private System.Windows.Forms.Label label_MaSach;
    }
}