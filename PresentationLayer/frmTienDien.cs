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
        private void ClearBox()
        {
            txtMaHoaDon.Clear();
            txtMaPhong.Clear();
            txtSoDienTieuThu.Clear();
            txtSoNuocTieuThu.Clear();
            dtpNgaylap.Value = DateTime.Now;
        }
        private void frmTienDien_Load(object sender, EventArgs e)
        {
            dgvSoDienTieuThu.DataSource = bll.SelectTienDien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertDienNuoc(ref err, txtMaHoaDon.Text, txtMaPhong.Text, dtpNgaylap.Value,Convert.ToInt32(txtSoDienTieuThu.Text), Convert.ToInt32(txtSoNuocTieuThu.Text), cbTrangThai.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã hóa đơn không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!bll.updateDienNuoc(ref err, txtMaHoaDon.Text, txtMaPhong.Text, dtpNgaylap.Value, Convert.ToInt32(txtSoDienTieuThu.Text), Convert.ToInt32(txtSoNuocTieuThu.Text), cbTrangThai.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã hóa đơn không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!bll.deleteDienNuoc(ref err, txtMaHoaDon.Text))
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTienDien_Load(sender,e);
            ClearBox();
            
        }

        private void dgvSoDienTieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaHoaDon.Text = dgvSoDienTieuThu.Rows[vitri].Cells[0].Value.ToString();
                txtMaPhong.Text = dgvSoDienTieuThu.Rows[vitri].Cells[1].Value.ToString();
                txtSoDienTieuThu.Text = dgvSoDienTieuThu.Rows[vitri].Cells[3].Value.ToString();
                txtSoNuocTieuThu.Text = dgvSoDienTieuThu.Rows[vitri].Cells[4].Value.ToString();
                cbTrangThai.Text = dgvSoDienTieuThu.Rows[vitri].Cells[5].Value.ToString();
            }
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {
            dgvSoDienTieuThu.DataSource = bll.PhongChuaThanhToan();
        }
    }
}
