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

        public bool insertToa(ref string err, string matoa, int sotang, int succhua, int sophongtoida)
        {
            return dal.MyExecuteNonQuery("insertToa",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaToa", matoa),
                new SqlParameter("@SoTang", sotang),
                new SqlParameter("@SucChua", succhua),
                new SqlParameter("@SoPhongToiDa", sophongtoida)
                );
        }

        public bool updateToa(ref string err, string matoa, int sotang, int succhua, int sophongtoida)
        {
            return dal.MyExecuteNonQuery("updateToa",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaToa", matoa),
                new SqlParameter("@SoTang", sotang),
                new SqlParameter("@SucChua", succhua),
                new SqlParameter("@SoPhongToiDa", sophongtoida)
                );
        }
        public bool deleteToa(ref string err, string matoa)
        {
            return dal.MyExecuteNonQuery(
                "deleteToa",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@MaToa", matoa)
                );
        }

    }
}
