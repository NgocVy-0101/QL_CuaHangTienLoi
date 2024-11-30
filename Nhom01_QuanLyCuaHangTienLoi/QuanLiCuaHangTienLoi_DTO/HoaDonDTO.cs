using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class HoaDonDTO
    {
        string maHoaDon, maNhanVien, maKhach;

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
        float giamGia;

        public float GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        DateTime ngayBan;

        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public HoaDonDTO(string mhd, string mnv, string mk, float sl, DateTime nb,  float tong)
        {
            MaHoaDon = mhd;
            MaNhanVien = mnv;
            MaKhach = mk;
            GiamGia = sl;
            NgayBan = nb;
            TongTien = tong;
        }
    }
}
