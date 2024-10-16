using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class SanPhamDTO
    {
        string maSanPham, tenSanPham, hinhAnh, maLoaiSanPham, maNCC, ghiChu;
        int soLuongCon;
        float giaNhap, giaBan;
        DateTime ngaySanXuat, ngayHetHan;
        string xuatXu;

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string MaLoaiSanPham { get => maLoaiSanPham; set => maLoaiSanPham = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int SoLuongCon { get => soLuongCon; set => soLuongCon = value; }
        public float GiaNhap { get => giaNhap; set => giaNhap = value; }
        public float GiaBan { get => giaBan; set => giaBan = value; }
        public DateTime NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string XuatXu { get => xuatXu; set => xuatXu = value; }

        public SanPhamDTO(string ma, string ten, int sl, float gn, float gb, string hi, DateTime nsx, DateTime nhh, string xx, string maloai, string mncc, string ghi)
        {
            MaSanPham = ma;
            TenSanPham = ten;
            SoLuongCon = sl;
            GiaNhap = gn;
            GiaBan = gb;
            HinhAnh = hi;
            MaLoaiSanPham = maloai;
            MaNCC = mncc;
            GhiChu = ghi;
            NgayHetHan = nhh;
            NgaySanXuat = nsx;
            XuatXu = xx;
        }
    }
}
