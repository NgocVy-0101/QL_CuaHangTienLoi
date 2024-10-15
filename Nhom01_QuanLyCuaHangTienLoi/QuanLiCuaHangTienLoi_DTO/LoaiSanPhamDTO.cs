using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class LoaiSanPhamDTO
    {
        string maLoaiSanPham, tenLoaiSanPham;

        public string MaLoaiSanPham { get => maLoaiSanPham; set => maLoaiSanPham = value; }
        public string TenLoaiSanPham { get => tenLoaiSanPham; set => tenLoaiSanPham = value; }

        public LoaiSanPhamDTO(string m,string t)
        {
            MaLoaiSanPham = m;
            TenLoaiSanPham = t;
        }
    }
}
