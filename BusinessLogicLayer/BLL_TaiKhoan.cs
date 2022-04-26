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
        public DataTable SelectNguoiDung()
        {
            string sql = "select * from TaiKhoan";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
       
    }
}
