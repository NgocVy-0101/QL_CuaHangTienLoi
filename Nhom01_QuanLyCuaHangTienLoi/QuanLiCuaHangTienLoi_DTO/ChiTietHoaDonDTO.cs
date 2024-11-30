using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class ChiTietHoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }

        // Constructor mặc định
        public ChiTietHoaDonDTO() { }

        // Constructor với tham số
        public ChiTietHoaDonDTO(string maHoaDon, string maSanPham, int soLuong, float thanhTien)
        {
            MaHoaDon = maHoaDon;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }

        // Phương thức mô phỏng tính toán tổng tiền (nếu cần)
        public void CalculateThanhTien(float donGia)
        {
            ThanhTien = SoLuong * donGia;
        }
    }
}
