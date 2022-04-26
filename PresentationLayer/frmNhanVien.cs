﻿using System;
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
        BusinessLogicLayer.BLL_NhanVien bll = new BusinessLogicLayer.BLL_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = bll.SelectNhanVien();
        }
        private void ClearBox()
        {
            txtMaNV.Clear();
            txtMaLoaiNV.Clear();
            txtMaToa.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtLuong.Clear();
            txtTimkiem.Clear();
            rbSearchTenNV.Checked = false;
            rbSearchMaNV.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertNhanVien(ref err,txtMaNV.Text,txtMaLoaiNV.Text,txtMaToa.Text, txtTenNV.Text, txtSDT.Text, Convert.ToInt32(txtLuong.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã nhân viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBox();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.updateNhanVien(ref err, txtMaNV.Text, txtMaLoaiNV.Text, txtMaToa.Text, txtTenNV.Text, txtSDT.Text, Convert.ToInt32(txtLuong.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã nhân viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.deleteNhanVien(ref err, txtMaNV.Text))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnRefresh_Click(sender, e);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dlr == DialogResult.No)
                return;
        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaNV.Text = dgvNhanvien.Rows[vitri].Cells[0].Value.ToString();
                txtMaLoaiNV.Text = dgvNhanvien.Rows[vitri].Cells[1].Value.ToString();
                txtMaToa.Text = dgvNhanvien.Rows[vitri].Cells[2].Value.ToString();
                txtTenNV.Text = dgvNhanvien.Rows[vitri].Cells[3].Value.ToString();
                txtSDT.Text = dgvNhanvien.Rows[vitri].Cells[4].Value.ToString();
                txtLuong.Text = dgvNhanvien.Rows[vitri].Cells[5].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            ClearBox();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập trường tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbSearchMaNV.Checked)
            {
                dgvNhanvien.DataSource = bll.searchMaNhanVien(txtTimkiem.Text);
            }
            else if (rbSearchTenNV.Checked)
            {
                dgvNhanvien.DataSource = bll.searchTenNhanVien(txtTimkiem.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
