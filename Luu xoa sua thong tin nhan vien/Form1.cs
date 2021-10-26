using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luu_xoa_sua_thong_tin_nhan_vien
{
    public partial class Form1 : Form
    {
        int i = 1;
        QuanLiHocSinh ql = new QuanLiHocSinh();
        SinhVien sinhvien;
        SQLSinhVien sqlSinhVien = new SQLSinhVien();
        //   QuanLiSinhVien quanLiSinhVien = new QuanLiSinhVien();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //       quanLiSinhVien.xoa(sinhvien.mssv);
            sqlSinhVien.removeSql(int.Parse(textBox2.Text));
            inDS();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ql.hocsinhs.Add(new hocsinh(textBox1.Text.ToString(), dateTimePicker1.Value, i++, textBox_diachi.Text, textBox_sdt.Text));

            //  quanLiSinhVien.add();
            //  sqlSinhVien.insertSql(new SinhVien(textBox1.Text.ToString(), dateTimePicker1.Value.ToString(), i++, textBox_diachi.Text, int.Parse(textBox_sdt.Text)));
            ql.SaveChanges();
            inDS();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string str = "";
            //foreach (SinhVien sv in quanLiSinhVien.list)
            //{

            //    str +="mssv: " +sv.mssv + " - họ tên: " + sv.hoTen + " - ngày sinh: " + sv.ngaySinh+"\n";
            //}
            inDS();



        }
        private void inDS()
        {
            dataGridView11.DataSource = null;
            dataGridView11.DataSource = sqlSinhVien.select();
            textBox2.Text = "";
            textBox1.Text = "";
            textBox_sdt.Text = "";
            textBox_diachi.Text = "";
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maHS = dataGridView11.Rows[e.RowIndex].Cells[0].Value.ToString();
            //  sinhvien = quanLiSinhVien.list.Where(sv => sv.mssv == int.Parse(maHS)).First();
            // textBox2.Text = sinhvien.mssv + "";
            textBox2.Text = maHS;

            //     textBox1.Text = sinhvien.hoTen;
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView11.Rows[e.RowIndex]; //dgvhanghoa la ten datagridview ban dat
            //    textBox2.Text  = row.Cells[2].Value.ToString(); //1 la collum hoac de name cung ok cu phap Cell["name"]
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //    quanLiSinhVien.update(sinhvien.mssv, new SinhVien(textBox1.Text, dateTimePicker1.Value.ToString(), int.Parse(textBox2.Text), textBox_diachi.Text, int.Parse(textBox_sdt.Text)));
            sqlSinhVien.update(new SinhVien(textBox1.Text.ToString(), dateTimePicker1.Value.ToString(), int.Parse(textBox2.Text), textBox_diachi.Text, int.Parse(textBox_sdt.Text)));
            inDS();

        }
    }

}
