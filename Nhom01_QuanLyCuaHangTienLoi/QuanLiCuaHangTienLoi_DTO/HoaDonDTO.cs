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
        int soLuong;
        DateTime ngayBan;
        float thanhTien, tongTien;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaKhach { get => maKhach; set => maKhach = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }

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
