using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class KhacHangDTO
    {
        string maKhach, tenKhach, dienThoai;
        int diem;

        public string MaKhach { get => maKhach; set => maKhach = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public int Diem { get => diem; set => diem = value; }

        public KhacHangDTO(string m, string t, string d, int di)
        {
            MaKhach = m;
            TenKhach = t;
            DienThoai = d;
            Diem = di;
        }
    }
}
