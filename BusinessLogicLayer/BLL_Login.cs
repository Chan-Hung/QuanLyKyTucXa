using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_Login
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public string loginForm(ref string err, string TaiKhoan, string MatKhau)
        {
            return dal.loginForm(
                    "QL_AuthoLogin",
                    CommandType.StoredProcedure,
                    ref err,
                    new SqlParameter("@UserName", TaiKhoan),
                    new SqlParameter("@Password", MatKhau)
                );
        }
    }
}
