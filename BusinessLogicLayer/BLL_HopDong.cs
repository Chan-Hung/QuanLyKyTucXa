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

        //public bool insertHopDong(ref string err, string maphong, string matoa, string maloaiphong, string trangthai)
        //{
        //    return dal.MyExecuteNonQuery(
        //        "insertPhong",
        //        CommandType.StoredProcedure,
        //        ref err,
        //        new SqlParameter("@MaPhong", maphong),
        //        new SqlParameter("@MaToa", matoa),
        //        new SqlParameter("@MaLoaiPhong", maloaiphong),
        //        new SqlParameter("@TrangThai", trangthai)
        //        );
        //}

    }
}
