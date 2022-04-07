using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_SinhVien
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public DataTable SelectSinhVien()
        {
            string sql = "select * from SinhVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public bool insertSinhVien(ref string err, string maSV, string tenSV, string gioiTinh, string SDT, string maTruong, string maPhong)
        {
            return dal.MyExecuteNonQuery("insertSinhVienKTX", CommandType.StoredProcedure, ref err, new SqlParameter("@MaSinhVien", maSV), 
                new SqlParameter("@TenSinhVien", tenSV),
                new SqlParameter("@GioiTinh", tenSV), 
                new SqlParameter("@SoDienThoai", SDT),
                new SqlParameter("@MaTruong", maTruong),
                new SqlParameter("@MaPhong", maPhong));
        }

    }
}
