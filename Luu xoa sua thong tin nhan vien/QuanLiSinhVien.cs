using System.Collections.Generic;
using System.Linq;

namespace Luu_xoa_sua_thong_tin_nhan_vien
{
    class QuanLiSinhVien
    {
       public List<SinhVien> list;

        public QuanLiSinhVien(List<SinhVien> list)
        {
            this.list = list;
        }

        public void add(SinhVien sv)
        {
            list.Add(sv);
            
        }
        public void xoa(int mssv)
        {
            
            SinhVien vien = null;
           foreach(SinhVien sv in list)
            {
                if(mssv == sv.mssv)
                {
                    vien = sv;
                }
            }
            list.Remove(vien);
        }
        public void update(int masv,SinhVien sv)
        {
            int i = list.IndexOf(list.Where(sc => sc.mssv == masv).First());

            list.Insert(i, sv);
            list.RemoveAt(i + 1);
            
            
        }
    }
   
}
