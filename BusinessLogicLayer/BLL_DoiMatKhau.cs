using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_DoiMatKhau
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public DataTable SelectMatKhauCu(string tendangnhap)
        {
            string sql = "Select MatKhau from TaiKhoan where tendangnhap = '" + tendangnhap + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public bool updateMatKhau(ref string err, string tendangnhap, string matkhau)
        {
            return dal.MyExecuteNonQuery(
                "sp_UpdateMatKhau",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@TenDangNhap", tendangnhap),
                new SqlParameter("@MatKhau", matkhau)
                );
        }
    }
}
