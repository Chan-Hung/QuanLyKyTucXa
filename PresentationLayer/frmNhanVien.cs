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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BusinessLogicLayer.BLL_NhanVien bll = new BusinessLogicLayer.BLL_NhanVien();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bll.SelectNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertNhanVien(ref err, txtMaNV.Text, txtMaLoaiNV.Text, txtMaToa.Text,
                txtTenNV.Text, txtSDT.Text,Convert.ToInt32(txtLuong.Text)))
                MessageBox.Show(err);
            else frmNhanVien_Load(sender, e);
        }
    }
}
