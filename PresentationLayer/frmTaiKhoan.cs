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
    public partial class frmTaiKhoan : Form
    {
        BusinessLogicLayer.BLL_TaiKhoan bll = new BusinessLogicLayer.BLL_TaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = bll.SelectTaiKhoan();
        }
    }
}
