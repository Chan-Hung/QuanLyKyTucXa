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
    }
}
