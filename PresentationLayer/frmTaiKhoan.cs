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
        private void ClearBox()
        {
            txtMaNV.Clear();
            txtTenDangNhap.Clear();
            txtMatkhau.Clear();
            cbMaLoaiTaiKhoan.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertTaiKhoan(ref err, txtMaNV.Text, txtTenDangNhap.Text, txtMatkhau.Text, cbMaLoaiTaiKhoan.Text))
            {

                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTaiKhoan_Load(sender, e);
            ClearBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string err = "";
            if (!bll.updateTaiKhoan(ref err, txtMaNV.Text, txtTenDangNhap.Text,  cbMaLoaiTaiKhoan.Text))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearBox();
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
                if (!bll.deleteTaiKhoan(ref err, txtMaNV.Text))
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

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                cbMaLoaiTaiKhoan.Text = dgvTaiKhoan.Rows[vitri].Cells[0].Value.ToString();
                txtMaNV.Text = dgvTaiKhoan.Rows[vitri].Cells[1].Value.ToString();
                txtTenDangNhap.Text = dgvTaiKhoan.Rows[vitri].Cells[2].Value.ToString();
                txtMatkhau.Text = dgvTaiKhoan.Rows[vitri].Cells[3].Value.ToString();
                txtMaNV.ReadOnly = true;
            }
        }
    }
}