using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class HoaDonDTO
    {
        string maHoaDon, maNhanVien, maKhach, maSanPham;

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        public string MaKhach
        {
            get { return maKhach; }
            set { maKhach = value; }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        DateTime ngayBan;

        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        float thanhTien, tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        public HoaDonDTO(string mhd, string mnv, string mk, string msp, int sl, DateTime nb, float tt, float tong)
        {
            MaHoaDon = mhd;
            MaNhanVien = mnv;
            MaKhach = mk;
            MaSanPham = msp;
            SoLuong = sl;
            NgayBan = nb;
            ThanhTien = tt;
            TongTien = tong;
        }
    }
}
