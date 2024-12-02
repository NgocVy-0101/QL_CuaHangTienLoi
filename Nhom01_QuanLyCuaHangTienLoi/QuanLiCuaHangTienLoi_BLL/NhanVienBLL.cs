using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DAL;
using QuanLiCuaHangTienLoi_DTO;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class NhanVienBLL
    {NhanVienDAL dal = new NhanVienDAL();
        public List<NhanVienDTO> NhanVien()
        {
            return dal.NhanVien();
        }

        public bool ThemNhanVien(NhanVienDTO nvDTO)
        {
            NhanVienDAL dal = new NhanVienDAL();
            return dal.ThemNhanVien(nvDTO);
        }

        public bool CapNhatNhanVien(NhanVienDTO nvDTO)
        {
            NhanVienDAL dal = new NhanVienDAL();
            return dal.CapNhatNhanVien(nvDTO);
        }

        public bool XoaNhanVien(string maNhanVien)
        {
            NhanVienDAL dal = new NhanVienDAL();
            return dal.XoaNhanVien(maNhanVien);
        }

        public bool DanNhap(string ma, string mk)
        {
            return dal.DangNhap(ma, mk);
        }    

        public NhanVienDTO NV(string m)
        {
            return dal.NV(m);
        }    
        public string MaNV()
        {
            return dal.MaNV();
        }
    }
}
