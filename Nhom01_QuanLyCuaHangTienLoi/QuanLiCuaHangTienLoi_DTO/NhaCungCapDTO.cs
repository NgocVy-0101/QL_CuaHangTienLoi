using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class NhaCungCapDTO
    {
        string maNCC, tenNCC, diaChi, sDT;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }


        public NhaCungCapDTO(string m, string t, string sdt,string dc)
        {
            MaNCC = m;
            TenNCC = t;
            SDT = sdt;
            DiaChi = dc;
        }
    }
}
