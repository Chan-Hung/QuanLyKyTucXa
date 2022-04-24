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
            MessageBox.Show("Bạn chưa chọn mã trường!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (!bll.insertSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
                MessageBox.Show(err);
            else frmSinhVien_Load(sender, e);
        }

        private void XoaTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void XoaTxtBox1_Click(object sender, EventArgs e)
        {
            txtMasv.Clear();
            txtTensv.Clear();
            txtSDT.Clear();
            txtMaTruong.Clear();
            txtMaPhong.Clear();
        }

        private void dgvSinhvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSinhvien.Rows[e.RowIndex].Cells != null)
            {
                dgvSinhvien.CurrentRow.Selected = true;
                txtMasv.Text = dgvSinhvien.Rows[e.RowIndex].Cells["MaSV"].FormattedValue.ToString();
                txtTensv.Text = dgvSinhvien.Rows[e.RowIndex].Cells["TenSV"].FormattedValue.ToString();
                cbGioitinh.Text = dgvSinhvien.Rows[e.RowIndex].Cells["GioiTinh"].FormattedValue.ToString();
                txtSDT.Text = dgvSinhvien.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
                txtMaTruong.Text = dgvSinhvien.Rows[e.RowIndex].Cells["MaTruong"].FormattedValue.ToString();
                txtMaPhong.Text = dgvSinhvien.Rows[e.RowIndex].Cells["MaPhong"].FormattedValue.ToString();

            }
        }
    }
}
