using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luu_xoa_sua_thong_tin_nhan_vien
{
    class SinhVien
    {
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public int mssv { get; set; }
        public string diaChi { get; set; }
        public int sdt { get; set; }

        public SinhVien(string hoTen, string ngaySinh, int mssv, string diaChi, int sdt)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.mssv = mssv;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }
    }
}

