using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_HeQuanTriCSDL
{
    public partial class BangDieuKhien : Form
    {
        public BangDieuKhien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_QuanLy_Sach_Click(object sender, EventArgs e)
        {
            listbox_Name F_QuanLySach = new listbox_Name();
            F_QuanLySach.Show();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button_Thoat_inBangDieuKhien_Click(object sender, EventArgs e)
        {
            ThongDiep.XacNhanThoat();
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            ThongDiep.XacNhanDangXuat();
        }

        private void button_QuanLy_TacGia_Click(object sender, EventArgs e)
        {
            ThongDiep.TinhNangDangXayDung();
        }

        private void button_MuonSach_Click(object sender, EventArgs e)
        {
            ThongDiep.TinhNangDangXayDung();
        }

        private void button_TraSach_Click(object sender, EventArgs e)
        {
            ThongDiep.TinhNangDangXayDung();
        }
    }
}
