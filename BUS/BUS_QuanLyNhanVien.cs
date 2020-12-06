using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    
    public class BUS_QuanLyNhanVien
    {
        Data dal = new Data();
        public DataTable ShowNhanVien()
        {
            string sql = "select MaNhanVien,TenNhanVien,GioiTinh,NgaySinh,QueQuan,TenChucVu"
                + " from NhanVien,ChucVu where NhanVien.MaChucVu = ChucVu.MaChucVu";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public DataTable ShowCbo()
        {
            string sql = "select MaChucVu,TenChucVu from ChucVu";
            DataTable dt = new DataTable();
            dt = dal.getTable(sql);
            return dt;
        }
        public void ThemNhanVien(string tenNv, string gt, string ns, string qq, string macv)
        {
            string sql = "insert into NhanVien values( ";
            sql += "N'" + tenNv + "'";
            sql += ",N'" + gt + "'";
            sql += ",'" + ns + "'";
            sql += ",N'" + qq + "'";
            sql += ",'" + macv + "')";
            dal.ExcuteNonQuery(sql);
        }

        public int XoaNhanVien(string ma)
        {
            string sql = "delete from NhanVien where MaNhanVien = ";
            sql += "'" + ma + "'";
            int row = dal.ExcuteNonQuery(sql);
            return row;
        }

    }
}
