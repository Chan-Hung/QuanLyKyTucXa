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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnlToaPhongSubMenu.Visible = false;
            pnlTuyChonSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pnlToaPhongSubMenu.Visible == true)
                pnlToaPhongSubMenu.Visible = false;
            if (pnlTuyChonSubMenu.Visible == true)
                pnlTuyChonSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlTuyChonSubMenu);
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnToaVaPhong_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlToaPhongSubMenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLSinhVien_Click(object sender, EventArgs e)
        {
            openChildForm(new PresentationLayer.frmSinhVien());
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DateLabel.Text = DateTime.Now.ToString("ddd, d MMMM yyyy");
        }

        private void btnQLToa_Click(object sender, EventArgs e)
        {
            openChildForm(new PresentationLayer.frmToa());
        }
    }
}
