using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class NhanVienDTO
    {
        string maNhanVien, tenNhanVien, gioiTinh, dienThoai, diaChi, matKhau;
        DateTime ngaySinh;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public NhanVienDTO(string m, string t, string gt, DateTime ns, string dt, string dc, string mk)
        {
            MaNhanVien = m;
            TenNhanVien = t;
            GioiTinh = gt;
            NgaySinh = ns;
            DienThoai = dt;
            DiaChi = dc;
            MatKhau = mk;
        }
    }
}
