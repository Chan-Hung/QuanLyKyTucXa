using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace QuanLyKyTucXa.PresentationLayer
{
    public partial class frmLogin : Form
    {
        BusinessLogicLayer.BLL_Login bll = new BusinessLogicLayer.BLL_Login();
        public frmLogin()
        {
            InitializeComponent();
        }
        //string strConnectionString = "Data Source=DESKTOP-07KO9B1\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security = True";
        //SqlConnection conn = new SqlConnection();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //conn = new SqlConnection(strConnectionString);
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.CommandText = "QL_AuthoLogin";
            //    cmd.Parameters.AddWithValue("@UserName", txtTaiKhoan.Text);
            //    cmd.Parameters.AddWithValue("@Password", txtMatKhau.Text);
            //    cmd.Connection = conn;
            //    object kq = cmd.ExecuteScalar();
            //    string code = Convert.ToString(kq);
            //    if (code == "01")
            //    {
            //        //MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        frmDashboard dashBoard = new frmDashboard();
            //        this.Hide();
            //        dashBoard.ShowDialog();
            //        this.Close();

            //    }
            //    else if (code == "02")
            //    {
            //        MessageBox.Show("Chào mừng Sinh viên KTX đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    else if (code == "03")
            //    {
            //        MessageBox.Show("Chào mừng Nhân viên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    else if (code == "04")
            //    {
            //        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


          
            string err = "";
            string check = bll.loginForm(ref err, txtTaiKhoan.Text, txtMatKhau.Text);
            if (check=="01")
            {
                //MessageBox.Show("Đã thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDashboard dashBoard = new frmDashboard();
                this.Hide();
                dashBoard.ShowDialog();
                this.Close();
            }
            else if(check == "02")
            {
                MessageBox.Show("Chào mừng Sinh viên KTX đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (check == "03")
            {
                MessageBox.Show("Chào mừng Nhân viên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (check == "04")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
