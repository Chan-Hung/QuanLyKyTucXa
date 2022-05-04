using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa.PresentationLayer
{
    public partial class frmDoiMatKhau : Form
    {
        BusinessLogicLayer.BLL_DoiMatKhau bll = new BusinessLogicLayer.BLL_DoiMatKhau();
        PresentationLayer.frmLogin lg = new PresentationLayer.frmLogin();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string err = "";
            //if (txtMatkhaucu.Text != bll.SelectMatKhauCu().Rows[0][0].ToString())
            //{
            //    MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (txtMatkhaumoi.Text != txtXacnhan.Text)
            //{
            //    MessageBox.Show("Xác nhận mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //bll.updateMatKhau(ref err, lg.tendangnhap, txtMatkhaumoi.Text);
            Close();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            txtMatkhaucu.Text = "";
            txtMatkhaumoi.Text = "";
            txtXacnhan.Text = "";
           //Console.WriteLine( bll.SelectMatKhauCu(lg.tendangnhap).Rows[0][0].ToString());
        }
    }
}
