using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FrmMain : Form
    {
        private Button currentButton;
        public FrmMain()
        {
            InitializeComponent();
            customizeDesing();
            btnCloseChildForm.Visible = false;
        }

        private void activeButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    disableButton();
                    Color color = Color.FromArgb(23, 24, 32);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void disableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(253, 192, 41);
                    previousBtn.ForeColor = Color.FromArgb(23, 24, 32);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void customizeDesing()
        {
            panelPhongSubMenu.Visible = false;
            panelDVSubMenu.Visible = false;
            panelTBSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelPhongSubMenu.Visible == true)
                panelPhongSubMenu.Visible = false;
            if (panelDVSubMenu.Visible == true)
                panelDVSubMenu.Visible = false;
            if (panelTBSubMenu.Visible == true)
                panelTBSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            disableButton();
            lblTitle.Text = "HELLO";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            openChildForm(new Form1());
            hideSubMenu();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            showSubMenu(panelPhongSubMenu);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_KHACHHANG());
            hideSubMenu();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            //openChildForm(new Frm_THANHTOAN());
            //hideSubMenu();
        }

        private void btnQLDP_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_QUANLYDATPHONG());
            hideSubMenu();
        }

        private void btnQLLP_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmLoaiPhong());
            hideSubMenu();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            showSubMenu(panelDVSubMenu);
        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_DICHVU());
            hideSubMenu();
        }

        private void btnCTSDDV_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmChiTietSuDungDV());
            hideSubMenu();
        }

        private void btnDKSDDV_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_DangKySuDungDv());
            hideSubMenu();
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            showSubMenu(panelTBSubMenu);
        }

        private void btnQLTB_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThietBi());
            hideSubMenu();
        }

        private void btnCTTB_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChiTietThietBi());
            hideSubMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            activeButton(sender);
            openChildForm(new Frm_KHACHHANG());
            hideSubMenu();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonQlphong_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Phong());
            hideSubMenu();
        }
    }
}
