using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_NhanVien
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public DataTable SelectNhanVien()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        
        public bool insertNhanVien(ref string err, string maNV, string maLoaiNV, string maToa, 
            string tenNV, string soDienThoai, int Luong)
        {
            return dal.MyExecuteNonQuery(
                "InsertNhanVien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@MaLoaiNV", maLoaiNV),
                new SqlParameter("@MaToa", maToa),
                new SqlParameter("@TenNV", tenNV),
                new SqlParameter("@SoDienThoai", soDienThoai),
                new SqlParameter("@Luong", Luong)
                );
        }
        public bool updateNhanVien(ref string err, string maNV, string maLoaiNV, string maToa,
           string tenNV, string soDienThoai, int Luong)
        {
            return dal.MyExecuteNonQuery(
                "UpdateNhanVien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@MaLoaiNV", maLoaiNV),
                new SqlParameter("@MaToa", maToa),
                new SqlParameter("@TenNV", tenNV),
                new SqlParameter("@SoDienThoai", soDienThoai),
                new SqlParameter("@Luong", Luong)
                );
        }
        public bool deleteNhanVien(ref string err, string maNV)
        {
            return dal.MyExecuteNonQuery(
                "deleteNhanVien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaNV", maNV)
                );
        }
    }
}
