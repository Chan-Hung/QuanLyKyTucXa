using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKyTucXa.DataAccessLayer
{
    public class DAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        String connString = @"Data Source=(local);Initial Catalog=QuanLyKTX;Integrated Security=True";
            /*"Data Source=JINKKY\\SQLEXPRESS;" +
            "Initial Catalog=QuanLyKTX;Integrated Security=True";*/

        public DAL()
        {
            cnn = new SqlConnection(connString);
            cmd = cnn.CreateCommand();
        }
        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable getTableFunc(String sql, params SqlParameter[] param )
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(sql, con);
                
                
                foreach (SqlParameter p in param)
                    cmd.Parameters.Add(p);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public void ExecNonQuery(String sql)
        {
            SqlConnection conn = GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            /*
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        
        public bool MyExecuteNonQuery(string strSQL,
            CommandType ct, ref string error,
            params SqlParameter[] param)
        {

            //Co f la gia tri tra ve
            bool f = false;
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            // cmd
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            // add parameters
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            // run command
            try
            {
                cmd.ExecuteNonQuery();
                //Thuc thi tot
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }
        public Boolean login(string sql)
        {
            SqlConnection conn = GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
                return true;
            else
                return false;
        }

    }
}
