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
        private void ClearBox()
        {
            txtMasv.Clear();
            txtTensv.Clear();
            cbGioitinh.Text = "";
            txtSDT.Clear();
            txtMaTruong.Clear();
            txtMaPhong.Clear();
            txtTimkiem.Clear();
            rbSearchMaSV.Checked = false;
            rbSearchTenSV.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.updateSinhVien(ref err, txtMasv.Text, txtTensv.Text, cbGioitinh.Text, txtSDT.Text, txtMaTruong.Text, txtMaPhong.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
            }

            else
            {
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.deleteSinhVien(ref err, txtMasv.Text))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnRefresh_Click(sender,e);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dlr == DialogResult.No)
                return;
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

        }

        private void dgvSinhvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập trường tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbSearchMaSV.Checked)
            {
                dgvSinhvien.DataSource = bll.searchMaSinhVien(txtTimkiem.Text);
            }
            else if (rbSearchTenSV.Checked)
            {
                dgvSinhvien.DataSource = bll.searchTenSinhVien(txtTimkiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmSinhVien_Load(sender, e);
            ClearBox();
        }

        private void rbSearchMaSV_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
