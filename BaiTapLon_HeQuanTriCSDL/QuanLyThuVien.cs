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
    public partial class F_QLSACH : Form
    {
        public F_QLSACH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_TaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btn_TruyCap_Click(object sender, EventArgs e)
        {
            string var_TaiKhoan = "admin";
            string var_MatKhau = "admin";
            if (textBox_TaiKhoan.Text == var_TaiKhoan && textBox_MatKhau.Text == var_MatKhau)
            {
                BangDieuKhien F_BangDieuKhien = new BangDieuKhien();
                F_BangDieuKhien.Show();
            } else
            {
                ThongDiep.ThongTinChuaChinhXac();
            }
        }

        private void textBox_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
