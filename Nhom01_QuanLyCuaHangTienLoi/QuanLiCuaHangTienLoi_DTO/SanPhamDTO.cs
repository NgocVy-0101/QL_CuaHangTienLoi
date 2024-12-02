using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class SanPhamDTO
    {
        string maSanPham, tenSanPham, maLoaiSanPham, maNCC, ghiChu;
        DateTime ngaySanXuat, ngayHetHan;
        string xuatXu;

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        int soLuongCon;

        public int SoLuongCon
        {
            get { return soLuongCon; }
            set { soLuongCon = value; }
        }
        float giaNhap, giaBan;

        public float GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public float GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string MaLoaiSanPham
        {
            get { return maLoaiSanPham; }
            set { maLoaiSanPham = value; }
        }

        public DateTime NgaySanXuat 
        {
            get { return ngaySanXuat; }
            set { ngaySanXuat = value; }
        }
        public DateTime NgayHetHan 
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }
        public string XuatXu 
        {
            get { return xuatXu; }
            set { xuatXu = value; }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }


        public SanPhamDTO(string ma, string ten, int sl, float gn, float gb,  DateTime nsx, DateTime nhh, string xx, string maloai, string mncc, string ghi)
        {
            MaSanPham = ma;
            TenSanPham = ten;
            SoLuongCon = sl;
            GiaNhap = gn;
            GiaBan = gb;
            MaLoaiSanPham = maloai;
            MaNCC = mncc;
            GhiChu = ghi;
            NgayHetHan = nhh;
            NgaySanXuat = nsx;
            XuatXu = xx;
        }
    }
}
