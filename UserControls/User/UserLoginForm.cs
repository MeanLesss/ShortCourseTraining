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

namespace ShortCourseTraining.UserControls.User
{
    public partial class UserLoginForm : UserControl
    {
        readonly Panel _panel;
        readonly Form _form;
        public UserLoginForm()
        {
            InitializeComponent();
        }
        public UserLoginForm(Panel welcomePanel, Form form)
        {
            InitializeComponent();
            _panel = welcomePanel;
            _form = form;
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _panel.Controls.Remove(this);
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            UserAuthentication authentication = new UserAuthentication();
            var user = authentication.STAuthentication(textBoxUsername.Text, textBoxPassword.Text);
            if (user != null)
            {
                new DashBoardAdmin(user).Show();
                _form.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Login failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void linkLabelForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
