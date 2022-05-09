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
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        private void ClearBox()
        {
            txtMaToa.Clear();
            txtSoTang.Text = "0";
            txtsptd.Text = "0";
            txtSucChua.Text = "0";
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
                btnRefresh_Click(sender, e);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmToa_Load(sender, e);
            ClearBox();
        }

        private void dgvToa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMaToa.Text = dgvToa.Rows[vitri].Cells[0].Value.ToString();
                txtSoTang.Text = dgvToa.Rows[vitri].Cells[1].Value.ToString();
                txtSucChua.Text = dgvToa.Rows[vitri].Cells[2].Value.ToString();
                txtsptd.Text = dgvToa.Rows[vitri].Cells[3].Value.ToString();
            }
        }
    }
}
