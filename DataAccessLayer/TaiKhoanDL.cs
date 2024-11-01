using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class TaiKhoanDL
    {
        private static TaiKhoanDL Instance;
        public static TaiKhoanDL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new TaiKhoanDL();
                }
                return Instance;
            }
        }
        private TaiKhoanDL() { }

        #region Kiểm Tra Đăng Nhập
        public bool KiemTraDangNhap(string maNV, string matKhau)
        {
            string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE MANV = @maNV AND MATKHAU = @matKhau";

            using (SqlConnection con = DataProvider.Openconnect())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                int count = (int)cmd.ExecuteScalar();
                DataProvider.Disconnect(con);

                return count > 0;
            }
        }


        private static void Disconnect(SqlConnection con)
        {
            throw new NotImplementedException();
        }

        private static SqlConnection Openconnect()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Đổi Mật Khẩu
        public bool DoiMatKhau(string MaNV, string MatKhauMoi)
        {
            try
            {
                string sql = "UPDATE TAIKHOAN SET MATKHAU = (select EncryptedData = EncryptByPassPhrase('!@#<>?', '"+ MatKhauMoi + "' )) WHERE MANV = @MANV";
                SqlConnection con = DataProvider.Openconnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MANV", MaNV);
                cmd.Connection = con;
                int rows = cmd.ExecuteNonQuery();
                DataProvider.Disconnect(con);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi database: " + ex.Message);
                return false;
            }
        }
        #endregion

        #region Lấy Mã Quyền
        public int GetMaQuyen(int manv)
        {
            string sql = "SELECT * FROM PHANQUYEN WHERE MANV = '" + manv + "'";
            DataTable dt = new DataTable();
            dt = DataProvider.GetTable(sql);
            string maquyen = dt.Rows[0][1].ToString();
            return int.Parse(maquyen);
        }
        #endregion

        #region Lấy Tên Quyền
        public string GetTenQuyen(int maquyen)
        {
            string sql = "SELECT TENQUYEN FROM QUYEN WHERE MAQUYEN = '" + maquyen + "'";
            DataTable dt = new DataTable();
            dt = DataProvider.GetTable(sql);
            string tenquyen = dt.Rows[0][0].ToString();
            return tenquyen;
        }

        #endregion
    }
}
