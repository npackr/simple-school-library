using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BaiTapLon_HeQuanTriCSDL
{
    class KetNoiCSDL
    {
        private static SqlConnection ckn;

        public static void KetNoiDenCSDL()
        {
            string ChuoiKetNoi;
            ChuoiKetNoi = @"Data Source=MACBOOKPRO-2012\SQLEXPRESS;Initial Catalog=QLSACH;User ID=thuthu;Password=thuthudethuong";
            ckn = new SqlConnection(ChuoiKetNoi);
            ckn.Open();
        }

        public static void NgatKetNoiCSDL()
        {
            ckn.Close();
            ckn.Dispose();
        }

        public static void LayMaTheLoai(ComboBox comboBox_Name)
        {
            KetNoiDenCSDL();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT MaTL, TenTL FROM TheLoai", ckn))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                comboBox_Name.DisplayMember = "TenTL";
                comboBox_Name.ValueMember = "MaTL";
                comboBox_Name.DataSource = dt;
            }
            NgatKetNoiCSDL();
        }
        public static void LayMaNhaXuatBan(ComboBox comboBox_Name)
        {
            KetNoiDenCSDL();
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT MaXB, TenXB FROM NhaXB", ckn))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                comboBox_Name.DisplayMember = "TenXB";
                comboBox_Name.ValueMember = "MaXB";
                comboBox_Name.DataSource = dt;
            }
            NgatKetNoiCSDL();
        }
        public static int ThemDuLieuSach(string MaSach, string TenSach, string MaXB, string NgayXB, string MaTL, string SoTrang)
        {
            StringBuilder thongBaoLoi = new StringBuilder();
            string NoiDungTruyVan = "EXEC sp_themSach '" + MaSach + "', N'" + TenSach + "', '" + SoTrang + "', '" + NgayXB + "', '" + MaTL + "', '" + MaXB + "';";
            KetNoiDenCSDL();

            using (ckn)
            {
                SqlCommand TruyVan = new SqlCommand(NoiDungTruyVan, ckn);

                try
                {
                    TruyVan.ExecuteNonQuery();
                    return 1;
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        thongBaoLoi.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" + "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " + ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }

                    MessageBox.Show(thongBaoLoi.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    ckn.Close();
                }
            }
        }
    }
}
