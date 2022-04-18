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
        public frmToa()
        {
            InitializeComponent();
        }

        BusinessLogicLayer.BLL_Toa bll = new BusinessLogicLayer.BLL_Toa();

        private void frmToa_Load(object sender, EventArgs e)
        {
            dgvToa.DataSource = bll.SelectToa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!bll.insertToa(ref err, txtMaToa.Text, Convert.ToInt32(txtSoTang.Text), Convert.ToInt32(txtSucChua.Text), Convert.ToInt32(txtSoPhongToiDa.Text)))
                MessageBox.Show(err);
            else frmToa_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvToa.CurrentCell.RowIndex;
            string strMaToa = dgvToa.Rows[r].Cells[0].Value.ToString();
            string err = "";
            if (!bll.deleteToa(ref err, strMaToa))
            {
                MessageBox.Show(err);

            }
            else
            {
                DialogResult tl = MessageBox.Show("Bạn có muốn xóa không?(Y/N)",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    frmToa_Load(sender, e);
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {

        }
        private void listSt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void XoaTextBox_Click(object sender, EventArgs e)
        {
            txtMaToa.Clear();
            txtSoTang.Clear();
            txtSoPhongToiDa.Clear();
            txtSucChua.Clear();
        }

        private void dgvToa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvToa.Rows[e.RowIndex].Cells != null)
            {
                dgvToa.CurrentRow.Selected = true;
                txtMaToa.Text = dgvToa.Rows[e.RowIndex].Cells["MaToa"].FormattedValue.ToString();
                txtSoTang.Text = dgvToa.Rows[e.RowIndex].Cells["SoTang"].FormattedValue.ToString();
                txtSoPhongToiDa.Text = dgvToa.Rows[e.RowIndex].Cells["SoPhongToiDa"].FormattedValue.ToString();
                txtSucChua.Text = dgvToa.Rows[e.RowIndex].Cells["SucChua"].FormattedValue.ToString();
            }
        }
    }
}
