using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luu_xoa_sua_thong_tin_nhan_vien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            diemsv.DataSource = new QuanLiDiemSV().DiemSinhVien1.ToList();
        }
        
       
    }
}
