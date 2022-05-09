using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_TienDien
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public DataTable SelectTienDien()
        {
            string sql = "select * from HoaDonTienDienNuoc";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public bool insertDienNuoc(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int sonuoctieuthu, string trangthai)
        {
            return dal.MyExecuteNonQuery("sp_InsertDienNuoc",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHoaDon", mahoadon),
                new SqlParameter("@MaPhong", maphong),
                new SqlParameter("@ngaylap", ngaylap),
                new SqlParameter("@sodientieuthu", sodientieuthu),
                new SqlParameter("@sonuoctieuthu", sonuoctieuthu),
                new SqlParameter("@trangthai", trangthai)
                );
        }

        public bool updateDienNuoc(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int sonuoctieuthu, string trangthai)
        {
            return dal.MyExecuteNonQuery("sp_UpdateDienNuoc",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHoaDon", mahoadon),
                new SqlParameter("@MaPhong", maphong),
                new SqlParameter("@ngaylap", ngaylap),
                new SqlParameter("@sodientieuthu", sodientieuthu),
                new SqlParameter("@sonuoctieuthu", sonuoctieuthu),
                new SqlParameter("@trangthai", trangthai)
                );
        }
        public bool deleteDienNuoc(ref string err, string mahoadon)
        {
            return dal.MyExecuteNonQuery(
                "sp_DeleteDienNuoc",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHoaDon", mahoadon)
                );
        }
        public DataTable PhongChuaThanhToan()
        {
            string sql = "SELECT * FROM fn_ShowPhongChuaThanhToan()";
            DataTable dt = new DataTable();
            dt = dal.getTableFunc(sql,
                new SqlParameter("", "Chưa thanh toán"));
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
