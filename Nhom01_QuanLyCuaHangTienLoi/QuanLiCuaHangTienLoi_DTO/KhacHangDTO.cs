﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangTienLoi_DTO
{
    public class KhachHangDTO
    {
        string maKhach, tenKhach, dienThoai;

        public string MaKhach
        {
            get { return maKhach; }
            set { maKhach = value; }
        }

        public string TenKhach
        {
            get { return tenKhach; }
            set { tenKhach = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        int diem;

        public int Diem
        {
            get { return diem; }
            set { diem = value; }
        }

        public KhachHangDTO(string m, string t, string d, int di)
        {
            MaKhach = m;
            TenKhach = t;
            DienThoai = d;
            Diem = di;
        }
    
    }
}
