using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabelCreateComapny_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {

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
