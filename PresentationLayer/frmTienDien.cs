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
    public partial class frmTienDien : Form
    {
        BusinessLogicLayer.BLL_TienDien bll = new BusinessLogicLayer.BLL_TienDien();
        public frmTienDien()
        {
            InitializeComponent();
        }

        private void lblMaPhong_Click(object sender, EventArgs e)
        {

        }

        private void lblSoDienTieuThu_Click(object sender, EventArgs e)
        {

        }

        private void dgvSoDienTieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmTienDien_Load(object sender, EventArgs e)
        {
            dgvSoDienTieuThu.DataSource = bll.SelectTienDien();

        }
    }
}
