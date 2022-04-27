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
    public partial class frmPhong : Form
    {
        BusinessLogicLayer.BLL_Phong bll = new BusinessLogicLayer.BLL_Phong();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void lblMaPhong_Click(object sender, EventArgs e)
        {

        }
        private void ClearBox()
        {
            txtMaPhong.Clear();
            txtMaToa.Clear();
            cbMaLoaiPhong.Text = "";
            cbTrangThai.Text = "Còn";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertPhong(ref err, txtMaPhong.Text, txtMaToa.Text, cbMaLoaiPhong.Text,cbTrangThai.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã phòng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = bll.SelectPhong();
            cbTrangThai.Text = "Còn";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.updatePhong(ref err, txtMaPhong.Text, txtMaToa.Text, cbMaLoaiPhong.Text, cbTrangThai.Text))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã phòng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaPhong.Text = dgvPhong.Rows[vitri].Cells[0].Value.ToString();
                cbMaLoaiPhong.Text = dgvPhong.Rows[vitri].Cells[2].Value.ToString();
                txtMaToa.Text = dgvPhong.Rows[vitri].Cells[1].Value.ToString();
                cbTrangThai.Text = dgvPhong.Rows[vitri].Cells[3].Value.ToString();
              
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.deletePhong(ref err, txtMaPhong.Text))
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
            frmPhong_Load(sender, e);
            ClearBox();
        }

        private void btnPhongTrong_Click(object sender, EventArgs e)
        {

        }
    }
}
