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
    }
}
