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

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dgvHopDong.DataSource = bll.SelectHopDong();
        }
    }
}
