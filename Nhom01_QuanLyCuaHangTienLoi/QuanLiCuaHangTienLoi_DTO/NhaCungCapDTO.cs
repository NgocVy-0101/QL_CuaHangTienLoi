using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class NhaCungCapDTO
    {
        string maNCC, tenNCC, diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public NhaCungCapDTO(string m, string t, string dc)
        {
            MaNCC = m;
            TenNCC = t;
            DiaChi = dc;
        }
    }
}
