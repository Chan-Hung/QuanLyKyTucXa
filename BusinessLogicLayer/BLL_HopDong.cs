using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_HopDong
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public DataTable SelectHopDong()
        {
            string sql = "select * from HopDongThuePhong";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public bool insertHopDong(ref string err, string mahd, string masv, DateTime ngaykhd, DateTime ngaykthd)
        {
            return dal.MyExecuteNonQuery(
                "sp_InsertHopDong",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHD", mahd),
                new SqlParameter("@MaSV", masv),
                new SqlParameter("@NgayKHD", ngaykhd),
                new SqlParameter("@NgayKTHD", ngaykthd)
                );
        }
        public bool updateHopDong(ref string err, string mahd, string masv, DateTime ngaykhd, DateTime ngaykthd)
        {
            return dal.MyExecuteNonQuery(
                "sp_UpdateHopDong",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHD", mahd),
                new SqlParameter("@MaSV", masv),
                new SqlParameter("@NgayKHD", ngaykhd),
                new SqlParameter("@NgayKTHD", ngaykthd)
                );
        }

        public bool deleteHopDong(ref string err, string mahd)
        {
            return dal.MyExecuteNonQuery(
                "sp_DeleteHopDong",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaHD", mahd)
                );
        }
    }
}
