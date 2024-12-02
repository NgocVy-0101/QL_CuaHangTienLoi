using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class NhanVienDTO
    {
        string maNhanVien, tenNhanVien, gioiTinh, dienThoai, diaChi, matKhau, quyen;

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }


        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }


        DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }


        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }


        public NhanVienDTO(string m, string t, string gt, DateTime ns, string dt, string dc, string mk, string q)
        {
            MaNhanVien = m;
            TenNhanVien = t;
            GioiTinh = gt;
            NgaySinh = ns;
            DienThoai = dt;
            DiaChi = dc;
            MatKhau = mk;
            Quyen = q;
        }
    }
}
