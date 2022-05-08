using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
            return dal.MyExecuteNonQuery(
                "sp_InsertSinhVien", 
                CommandType.StoredProcedure, 
                ref err, 
                new SqlParameter("@MaSinhVien", maSV), 
                new SqlParameter("@TenSinhVien", tenSV),
                new SqlParameter("@GioiTinh", tenSV),
                new SqlParameter("@SoDienThoai", SDT),
                new SqlParameter("@MaTruong", maTruong),
                new SqlParameter("@MaPhong", maPhong)
                );
        }
        public bool updateSinhVien(ref string err, string maSV, string tenSV, string gioiTinh, string SDT, string maTruong, string maPhong)
        {
            return dal.MyExecuteNonQuery(
                "sp_UpdateSinhVien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaSinhVien", maSV),
                new SqlParameter("@TenSinhVien", tenSV),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@SoDienThoai", SDT),
                new SqlParameter("@MaTruong", maTruong),
                new SqlParameter("@MaPhong", maPhong)
                );
        }

        public bool deleteSinhVien(ref string err, string maSV)
        {
            return dal.MyExecuteNonQuery(
                "sp_DeleteSinhVien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaSinhVien", maSV)
                );
        }

        public DataTable searchTenSinhVien(string tensv)
        {
            string sql = "SELECT * FROM fn_SearchTenSV(@TenSinhVien)";
            DataTable dt = new DataTable();
            dt = dal.getTableFunc(sql, 
                new SqlParameter("@TenSinhVien", tensv));
            return dt;
        }
        public DataTable searchMaSinhVien(string masv)
        {
            string sql = "SELECT * FROM fn_SearchMaSV(@MaSinhVien)";
            DataTable dt = new DataTable();
            dt = dal.getTableFunc(sql,
                new SqlParameter("@MaSinhVien", masv));
            return dt;
        }
        public DataTable searchTenToa(string toa)
        {
            string sql = "SELECT * FROM fn_SearchSVToa(@MaToa)";
            DataTable dt = new DataTable();
            dt = dal.getTableFunc(sql,
                new SqlParameter("@MaToa", toa));
            return dt;
        }
        public DataTable tienPhongCuaSV()
        {
            string sql = "select * from TienPhongMoiSV";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public bool thanhToanPhong(ref string err, string maPhong)
        {
            return dal.MyExecuteNonQuery(
                "sp_UpdateThanhToan",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaPhong", maPhong)
                );
        }

    }
}
