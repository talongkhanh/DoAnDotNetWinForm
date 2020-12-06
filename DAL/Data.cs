using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=ANOS\SQLEXPRESS01;Initial Catalog=QLKS3;Integrated Security=True");
        }
        //trả về 1 bảng lưu trữ
        public DataTable getTable(string strsql)
        {
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(strsql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //Thực thi câu lệnh
        public int ExcuteNonQuery(string strsql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand com = new SqlCommand(strsql, conn);
            int row = com.ExecuteNonQuery();
            com.Dispose();
            com.Clone();
            return row;
        }
    }
}
