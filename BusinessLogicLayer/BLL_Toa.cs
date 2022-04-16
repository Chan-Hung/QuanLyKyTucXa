using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace QuanLyKyTucXa.BusinessLogicLayer
{
    class BLL_Toa
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();

        public DataTable SelectToa()
        {
            string sql = "select * from Toa";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public bool insertToa(ref string err, string maToa, int soTang, int sucChua, int soPhongToiDa)
        {
            return dal.MyExecuteNonQuery(
                "InsertToa",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaToa", maToa),
                new SqlParameter("@SoTang", soTang),
                new SqlParameter("@SucChua", sucChua),
                new SqlParameter("@SoPhongToiDa", soPhongToiDa)
                );
        }
    }
}
