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
    public partial class frmHopDong : Form
    {
        BusinessLogicLayer.BLL_HopDong bll = new BusinessLogicLayer.BLL_HopDong();
        public frmHopDong()
        {
            InitializeComponent();
        }
        private void ClearBox()
        {
            txtMaHD.Clear();
            txtMaSV.Clear();
            dtpNgayky.Value = DateTime.Now;
            dtpNgayketthuc.Value = DateTime.Now;
        }

        //Tự động thêm -> cần disable nút này
        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertHopDong(ref err, txtMaHD.Text, txtMaSV.Text, dtpNgayky.Value, dtpNgayketthuc.Value))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã hợp đồng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                frmHopDong_Load(sender, e);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBox();
            }
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dgvHopDong.DataSource = bll.SelectHopDong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.updateHopDong(ref err, txtMaHD.Text, txtMaSV.Text, dtpNgayky.Value, dtpNgayketthuc.Value))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã hợp đồng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                frmHopDong_Load(sender, e);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearBox();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                string err = "";
                if (!bll.deleteHopDong(ref err, txtMaHD.Text))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmHopDong_Load(sender, e);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBox();
                }
            }
            else if (dlr == DialogResult.No)
                return;
        }

    }
}
