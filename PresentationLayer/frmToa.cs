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
    public partial class frmToa : Form
    {
        BusinessLogicLayer.BLL_Toa bll = new BusinessLogicLayer.BLL_Toa();

        public frmToa()
        {
            InitializeComponent();
        }

        private void frmToa_Load(object sender, EventArgs e)
        {
            dgvToa.DataSource = bll.SelectToa();

        }

        private void lblSoTang_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertToa(ref err, txtMaToa.Text, Convert.ToInt32(txtSoTang.Text), Convert.ToInt32(txtSucChua.Text), Convert.ToInt32(txtsptd.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã tòa không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                frmToa_Load(sender, e);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ClearBox();
            }
        }
        private void ClearBox()
        {
            txtMaToa.Clear();
            txtSoTang.Clear();
            txtsptd.Clear();
            txtSucChua.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.updateToa(ref err, txtMaToa.Text, Convert.ToInt32(txtSoTang.Text), Convert.ToInt32(txtSucChua.Text), Convert.ToInt32(txtsptd.Text)))
            {
                if (err.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã tòa không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearBox();
                }
                else
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                frmToa_Load(sender, e);
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
                if (!bll.deleteToa(ref err, txtMaToa.Text))
                {
                    MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmToa_Load(sender, e);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBox();
                }
            }
            else if (dlr == DialogResult.No)
                return;
        }
    }
}
