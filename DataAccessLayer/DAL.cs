using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ADO.NET
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKyTucXa.DataAccessLayer
{
    public class DAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter adp;

        string strConnect = "Data Source = (local); Initial Catalog = QuanLyKTX; Intergrated Security = True";

        public DAL()
        {
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public boo


    }


}
