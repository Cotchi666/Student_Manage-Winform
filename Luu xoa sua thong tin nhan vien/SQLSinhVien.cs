using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luu_xoa_sua_thong_tin_nhan_vien
{
    class SQLSinhVien
    {
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QuanLiHocSinh;Integrated Security=True");
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;


        public DataTable select()
        {
            DataTable data = new DataTable();
            sqlConnect.Open();
            sqlCommand = new SqlCommand("SELECT [maHS] ,[tenHS],[diaChi],[ngaySinh] ,[dienThoai] FROM[dbo].[hocsinh]", sqlConnect);
            new SqlDataAdapter(sqlCommand).Fill(data);
            sqlConnect.Close();
            return data;
        }
        public void insertSql(SinhVien sv)
        {
            sqlConnect.Open();
            sqlCommand = new SqlCommand("INSERT INTO [dbo].[hocsinh] ([tenHS],[diaChi] ,[ngaySinh] ,[dienThoai]) VALUES('" + sv.hoTen + "','" + sv.diaChi + "','" + sv.ngaySinh + "','" + sv.sdt + "')", sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data has saved in DataBase");
            sqlConnect.Close();
        }
        public void removeSql(int mahs)
        {
            sqlConnect.Open();
            sqlCommand = new SqlCommand("DELETE FROM [dbo].[hocsinh] WHERE [maHS] =" + mahs, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data has removed in DataBase");
            sqlConnect.Close();
        }
        public void update(SinhVien sv)
        {
            sqlConnect.Open();
            sqlCommand = new SqlCommand("UPDATE [dbo].[hocsinh]SET[tenHS] = '" + sv.hoTen + "',[diaChi] = '" + sv.diaChi+"',[ngaySinh] = '"+sv.ngaySinh+"',[dienThoai] = '"+sv.sdt+"'WHERE maHS =" + sv.mssv, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data has updated in DataBase");
            sqlConnect.Close();
        }
    }
}
