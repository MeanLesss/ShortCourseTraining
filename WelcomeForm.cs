using ShortCourseTraining.Model;
using System;
using System.Windows.Forms;
using ShortCourseTraining.UserControls.User;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace ShortCourseTraining
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        //window move area

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void panelWelcome_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                NativeMethod.ReleaseCapture();
                NativeMethod.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void WelcomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethod.ReleaseCapture();
                NativeMethod.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonSchool_Click(object sender, EventArgs e)
        {
            /* LogInForm logInForm = new LogInForm();
             logInForm.Show();*/
            var companyLoginFormUC = new CompanyLoginFormUC(panelWelcome,this);
            panelWelcome.Controls.Add(companyLoginFormUC);
            companyLoginFormUC.Show();
            companyLoginFormUC.BringToFront();
        }

        private void ButtonStudent_Click(object sender, EventArgs e)
        {
            var userLoginFormUC = new UserLoginForm(panelWelcome, this);
            panelWelcome.Controls.Add(userLoginFormUC);
            userLoginFormUC.Show();
            userLoginFormUC.BringToFront();
        }

        private void iconButtonInfo_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void iconButtonInfo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(@"Mid term project(Short Course Training
Group : SS15
Team name : (Project 7)
-KANG Sokvimean
-HIV Vandeth
-Chhorn Phally
-Lim Channara
-Phin Chanveasna", iconButtonInfo);

        }
    }
}
