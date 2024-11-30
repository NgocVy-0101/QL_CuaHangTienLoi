using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiCuaHangTienLoi_DAL
{
    public class NhanVienDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public NhanVienDAL()
        {
            string s = @"Data Source=LAPTOP-LDL5LP51\SQLEXPRESS;Initial Catalog=QLCHTL;Integrated Security=True";
            conn = new SqlConnection(s);
        }
        public List<NhanVienDTO> NhanVien()
        {
            List<NhanVienDTO> k = new List<NhanVienDTO>();
            string sql = "select * from NhanVien";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "NhanVien");

            //Thêm khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["NhanVien"].Columns[0];
            ds.Tables["NhanVien"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["NhanVien"].Rows)
            {
                string m = i["MaNhanVien"].ToString();
                string t = i["TenNhanVien"].ToString();
                string gt = i["GioiTinh"].ToString();
                DateTime ns = (DateTime)i["NgaySinh"];
                string dt = i["DienThoai"].ToString();
                string dc = i["DiaChi"].ToString();
                string mk = i["MatKhau"].ToString();
                NhanVienDTO o = new NhanVienDTO(m,t,gt,ns,dt,dc,mk);
                k.Add(o);
            }

            return k;
        }

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @TenDangNhap AND MatKhau = @MatKhau";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                conn.Open();

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
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
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public bool ThemNhanVien(NhanVienDTO nvDTO)
        {
            try
            {
                string sql = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DienThoai, DiaChi, MatKhau) " +
                             "VALUES (@MaNhanVien, @TenNhanVien, @GioiTinh, @NgaySinh, @DienThoai, @DiaChi, @MatKhau)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaNhanVien", nvDTO.MaNhanVien);
                cmd.Parameters.AddWithValue("@TenNhanVien", nvDTO.TenNhanVien);
                cmd.Parameters.AddWithValue("@GioiTinh", nvDTO.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nvDTO.NgaySinh);
                cmd.Parameters.AddWithValue("@DienThoai", nvDTO.DienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", nvDTO.DiaChi);
                cmd.Parameters.AddWithValue("@MatKhau", nvDTO.MatKhau);  // Mật khẩu mặc định

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL

                return rowsAffected > 0; // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; // Nếu có lỗi xảy ra, trả về false
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public bool CapNhatNhanVien(NhanVienDTO nvDTO)
        {
            try
            {
                string sql = "UPDATE NhanVien SET " +
                             "TenNhanVien = @TenNhanVien, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, " +
                             "DienThoai = @DienThoai, DiaChi = @DiaChi, MatKhau = @MatKhau " +
                             "WHERE MaNhanVien = @MaNhanVien";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaNhanVien", nvDTO.MaNhanVien);
                cmd.Parameters.AddWithValue("@TenNhanVien", nvDTO.TenNhanVien);
                cmd.Parameters.AddWithValue("@GioiTinh", nvDTO.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nvDTO.NgaySinh);
                cmd.Parameters.AddWithValue("@DienThoai", nvDTO.DienThoai);
                cmd.Parameters.AddWithValue("@DiaChi", nvDTO.DiaChi);
                cmd.Parameters.AddWithValue("@MatKhau", nvDTO.MatKhau);  // Mật khẩu có thể thay đổi khi cập nhật

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL

                return rowsAffected > 0; // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; // Nếu có lỗi xảy ra, trả về false
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public bool XoaNhanVien(string maNhanVien)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số vào câu lệnh SQL
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL

                return rowsAffected > 0; // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; // Nếu có lỗi xảy ra, trả về false
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


    }
}
