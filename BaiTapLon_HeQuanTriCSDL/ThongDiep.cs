using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_HeQuanTriCSDL
{
    class ThongDiep
    {
        public static void TinhNangDangXayDung()
        {
            MessageBox.Show("Tính năng đang được xây dựng, vui lòng quay lại sau~", "Tính năng đang phát triển");
        }

        public static void XacNhanThoat()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes) { Application.Exit(); }
        }

        public static void XacNhanThaoTac()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn đã chắc chắn với thông tin mình đã nhập hay chưa?", "Xác nhận lại thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static void XacNhanDangXuat()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất tài khoản hiện tại không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) { Form.ActiveForm.Close();  }
        }

        public static void ThongTinChuaChinhXac()
        {
            MessageBox.Show("Thông tin bạn nhập vào chưa chính xác, vui lòng kiểm tra và sửa lại cho đúng!", "Thông tin chưa chính xác", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
