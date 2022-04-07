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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        BusinessLogicLayer.BLL_SinhVien bll = new BusinessLogicLayer.BLL_SinhVien();

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhvien.DataSource = bll.SelectSinhVien();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

        }

        private void txtQuequan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
                MessageBox.Show(err);
            else frmSinhVien_Load(sender, e);
        }
    }
}
