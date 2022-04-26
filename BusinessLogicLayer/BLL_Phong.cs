using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_Phong
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public DataTable SelectPhong()
        {
            string sql = "select * from Phong";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public bool insertPhong(ref string err, string maphong, string matoa, string maloaiphong, string trangthai)
        {
            return dal.MyExecuteNonQuery(
                "sp_InsertPhong",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaPhong", maphong),
                new SqlParameter("@MaToa", matoa),
                new SqlParameter("@MaLoaiPhong", maloaiphong),
                new SqlParameter("@TrangThai", trangthai)
                );
        }

        public bool updatePhong(ref string err, string maphong, string matoa, string maloaiphong, string trangthai)
        {
            return dal.MyExecuteNonQuery(
                "sp_UpdatePhong",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaPhong", maphong),
                new SqlParameter("@MaToa", matoa),
                new SqlParameter("@MaLoaiPhong", maloaiphong),
                new SqlParameter("@TrangThai", trangthai)
                );
        }
        public bool deletePhong(ref string err, string maphong)
        {
            return dal.MyExecuteNonQuery(
                "sp_DeletePhong",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaPhong", maphong)
                );
        }

    }
}
