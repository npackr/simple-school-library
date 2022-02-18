using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_HeQuanTriCSDL
{
    public partial class listbox_Name : Form
    {
        public listbox_Name()
        {
            InitializeComponent();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSACH_Sach_DataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLSACH_Sach_DataSet.Sach);
            KetNoiCSDL.LayMaTheLoai(comboBox_MaTheLoai);
            KetNoiCSDL.LayMaNhaXuatBan(comboBox_NhaXuatBan);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_MaTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button_ThemSach_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_SoTrang.Text) < 1) { ThongDiep.ThongTinChuaChinhXac(); }
            else
            {
                string MaSach = textBox_MaSach_inQuanLySach.Text;
                string TenSach = textBox_TenSach_inQuanLySach.Text;
                string NgayXB = dateTimePicker_NgayXuatBan.Value.Date.ToShortDateString();
                string MaTL = comboBox_MaTheLoai.SelectedValue.ToString().Trim();
                string MaXB = comboBox_NhaXuatBan.SelectedValue.ToString().Trim();
                string SoTrang = textBox_SoTrang.Text;
                if (KetNoiCSDL.ThemDuLieuSach(MaSach, TenSach, MaXB, NgayXB, MaTL, SoTrang) == 1)
                {
                    MessageBox.Show("Đã thêm thông tin: " + MaSach + ", tựa đề: " + TenSach + ", xuất bản ngày: " + NgayXB + " có mã thể loại: " + MaTL + ", do nhà xuất bản có mã: " + MaXB + " xuất bản, tổng độ dài: " + SoTrang + " trang");
                    this.sachTableAdapter.Fill(this.qLSACH_Sach_DataSet.Sach);
                }
                else
                {
                    MessageBox.Show("Đã phát sinh lỗi khi thêm bản ghi vào hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_QLSACH_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
