using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_TaiKhoan
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public DataTable SelectTaiKhoan()
        {
            string sql = "select * from TaiKhoan";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
       public bool insertTaiKhoan(ref string err, string manv, string tendangnhap, string matkhau,string maloaitaikhoan)
        {
            return dal.MyExecuteNonQuery("sp_InsertTaiKhoan",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@manv", manv),
                new SqlParameter("@tendangnhap", tendangnhap),
                new SqlParameter("@matkhau", matkhau),
                new SqlParameter("@MaLoaiTaiKhoan", maloaitaikhoan)
                );
        }
        public bool updateTaiKhoan(ref string err, string manv, string tendangnhap, string maloaitaikhoan)
        {
            return dal.MyExecuteNonQuery("sp_UpdateTaiKhoan",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@manv", manv),
                new SqlParameter("@tendangnhap", tendangnhap),
                new SqlParameter("@MaLoaiTaiKhoan", maloaitaikhoan)
                );
        }
        public bool deleteTaiKhoan(ref string err, string manv)
        {
            return dal.MyExecuteNonQuery(
                "sp_DeleteTaiKhoan",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@manv", manv)
                );
        }
    }
}
