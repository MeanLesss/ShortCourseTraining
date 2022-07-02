using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShortCourseTraining.Database;
using ShortCourseTraining.UserControls;

namespace ShortCourseTraining
{
    public partial class CompanyLoginFormUC : UserControl
    {
        Panel _panel;
        public CompanyLoginFormUC()
        {
            InitializeComponent();
        }
        
        public CompanyLoginFormUC(Panel welcomePanel)
        {
            InitializeComponent();
            _panel = welcomePanel;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ButtonLogIn.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            _panel.Controls.Remove(this);
        }
        
        private void linkLabelCreateCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateCompany company = new CreateCompany(_panel);
            _panel.Controls.Add(company);
            company.Show();
            company.BringToFront();
            _panel.Controls.Remove(this);
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            UserAuthentication authentication = new UserAuthentication();
            var user = authentication.AdminAuthentication(textBoxUsername.Text, textBoxPassword.Text);
            if (user != null)
            {
                //MessageBox.Show(user.Username+ user.Password);
                //new TESTER(user).Show();
                new DashBoardAdmin(user).Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Login failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            AdminSignUpUC adminSignUpUC = new AdminSignUpUC();
            _panel.Controls.Add(adminSignUpUC);
            adminSignUpUC.Show();
            adminSignUpUC.BringToFront();
        }

    }
}
