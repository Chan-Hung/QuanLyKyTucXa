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
            string sql = "select * from TienDienSuDung";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public bool insertTienDien(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int tonggiatri)
        {
            return dal.MyExecuteNonQuery("sp_InsertTienDien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHoaDon", mahoadon),
                new SqlParameter("@MaPhong", maphong),
                new SqlParameter("@ngaylap", ngaylap),
                new SqlParameter("@sodientieuthu", sodientieuthu),
                new SqlParameter("@tonggiatri", tonggiatri)
                );
        }

        public bool updateTienDien(ref string err, string mahoadon, string maphong, DateTime ngaylap, int sodientieuthu, int tonggiatri)
        {
            return dal.MyExecuteNonQuery("sp_UpdateTienDien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHoaDon", mahoadon),
                new SqlParameter("@MaPhong", maphong),
                new SqlParameter("@ngaylap", ngaylap),
                new SqlParameter("@sodientieuthu", sodientieuthu),
                new SqlParameter("@tonggiatri", tonggiatri)
                );
        }
        public bool deleteTienDien(ref string err, string mahoadon)
        {
            return dal.MyExecuteNonQuery(
                "sp_DeleteTienDien",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHoaDon", mahoadon)
                );
        }
    }
}
