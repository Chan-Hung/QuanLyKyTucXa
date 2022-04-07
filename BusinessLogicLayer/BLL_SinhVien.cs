using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

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

    }
}
