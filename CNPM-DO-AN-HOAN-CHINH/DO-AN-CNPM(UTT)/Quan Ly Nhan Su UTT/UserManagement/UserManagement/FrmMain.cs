using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public delegate void SendLogin(string FullNameValue, int UserId);
    public partial class FrmMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private int Id;
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            random = new Random();
            btnCloseChildForm.Visible = false;
        }

        private void SetCurentUser(string FullNameValue, int UserId) //get values receive form frmlogin
        {
            string prefix = "Xin chào bạn : " + FullNameValue + "  ";
            linkUserLogin.Text = prefix + "Đăng xuất";
            linkUserLogin.LinkArea = new LinkArea(prefix.Length, linkUserLogin.Text.Length - prefix.Length);
            linkUserLogin.Visible = true;
            BtnLogin.Visible = false;
            btnCloseChildForm.Visible = false;
            Login();
            lblTitle.Text = "Trang chủ";
            Id = UserId;
        }

        private void Logout()
        {
            ModuleBonus.Visible = false;
            ModuleUserPenalty.Visible = false;
            ModuleBonusUser.Visible = false;
            ModulePenalty.Visible = false;
            ModuleSalary.Visible = false;
            ModuleWork.Visible = false;
            ModuleDepartment.Visible = false;
            ModuleContract.Visible = false;
            ModuleCalculationSalary.Visible = false;
            ModuleSalaryAdvance.Visible = false;
            ModuleUser.Visible = false;
            BtnLogin.Visible = true;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisnableButton();
            lblTitle.Text = "Trang chủ";
            /*
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            */
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void DisnableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(198, 226, 255);
                    previousBtn.ForeColor = Color.FromArgb(0, 0, 0);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildFormLogin(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            DisnableButton();
            btnCloseChildForm.Visible = true;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisnableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void Login()
        {
            ModuleContract.Visible = true;
            ModuleBonus.Visible = true;
            ModuleUserPenalty.Visible = true;
            ModuleBonusUser.Visible = true;
            ModulePenalty.Visible = true;
            ModuleSalary.Visible = true;
            ModuleWork.Visible = true;
            ModuleDepartment.Visible = true;
            ModuleCalculationSalary.Visible = true;
            ModuleSalaryAdvance.Visible = true;
            ModuleUser.Visible = true;
            BtnLogin.Visible = false;
        }

        private void ModuleUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUser(), sender);
        }

        private void ModuleDepartment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDepartment(), sender);
        }

        private void ModuleBonus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBonus(), sender);
        }

        private void ModulePenalty_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPenalty(), sender);
        }

        private void ModuleContract_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChangePassword(Id), sender);
        }

        private void ModuleSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSalaryBase(), sender);
        }

        private void ModuleWork_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmManagerWorking(), sender);
        }
        

        private void ModuleBonusUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUserBonus(), sender);
        }

        //phạt
        private void ModuleBonusPenalty_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUserPenalty(), sender);
        }

        private void ModuleCalculationSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCaculationSalary(), sender);
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            OpenChildFormLogin(new FrmLogin(SetCurentUser), sender);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void linkUserLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkUserLogin.Visible = false;
            BtnLogin.Visible = true;
            Logout();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            linkUserLogin.Links.Clear();
            Reset();
        }

        private void ModuleSalaryAdvance_Click(object sender, EventArgs e)
        {
            OpenChildFormLogin(new FrmSalaryAdvance(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
