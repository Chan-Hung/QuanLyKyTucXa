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
        BusinessLogicLayer.BLL_SinhVien bll = new BusinessLogicLayer.BLL_SinhVien();

        public frmSinhVien()
        {
            InitializeComponent();
        }

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTensv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbGioitinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSDT.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaTruong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã trường!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bll.updateSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
                MessageBox.Show(err);
            else frmSinhVien_Load(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string err = "";
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bll.deleteSinhVien(ref err, txtMasv.Text))
                MessageBox.Show(err);
            else frmSinhVien_Load(sender, e);
        }

        private void lblMaSV_Click(object sender, EventArgs e)
        {

        }

        private void lblTenSV_Click(object sender, EventArgs e)
        {

        }

        private void txtMasv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTensv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSV_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMasv.Text = dgvSinhvien.Rows[vitri].Cells[0].Value.ToString();
                txtTensv.Text = dgvSinhvien.Rows[vitri].Cells[1].Value.ToString();
                cbGioitinh.Text = dgvSinhvien.Rows[vitri].Cells[2].Value.ToString();
                txtSDT.Text = dgvSinhvien.Rows[vitri].Cells[3].Value.ToString();
                txtMaTruong.Text = dgvSinhvien.Rows[vitri].Cells[4].Value.ToString();
                txtMaPhong.Text = dgvSinhvien.Rows[vitri].Cells[5].Value.ToString();
            }
        }
    }
}
