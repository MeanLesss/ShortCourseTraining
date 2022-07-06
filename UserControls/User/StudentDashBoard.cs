using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShortCourseTraining.Model;
using ShortCourseTraining.UserControls.DisplayControls.Cards;
using ShortCourseTraining.UserControls.DisplayControlStudent;

namespace ShortCourseTraining.UserControls.User
{
    public partial class StudentDashBoard : UserControl
    {
        private readonly Model.User _user = null;
        readonly Panel _panel;
        readonly Form _form;
        public StudentDashBoard(Model.User user, Panel welcomePanel, Form form)
        {
            InitializeComponent(); 
            _user = user;
            _panel = welcomePanel;
            _form = form;
        }

        private void StudentDashBoard_Load(object sender, System.EventArgs e)
        {
            labelUsername.Text = _user.Username;
            labelSTID.Text = _user.UserID.ToString();
            roundPictureBoxStudent.Image = _user.Photo;

            var stdc = new StudentDashboardControl(_user);
            panelControls.Controls.Add(stdc);
            stdc.Dock = DockStyle.Fill;

            var ptr = NativeMethod.CreateRoundRectRgn(5, 5, panelControls.Width, panelControls.Height, 20, 20);
            panelControls.Region = Region.FromHrgn(ptr);
            NativeMethod.DeleteObject(ptr);
        }

        private void iconButtonLogOut_Click(object sender, System.EventArgs e)
        {
            _form.BackColor = Color.White;
            _panel.Controls.Remove(this);
            var loginUser = new UserLoginForm(_panel, _form);
            _panel.Controls.Add(loginUser);
            loginUser.BringToFront();
            loginUser.Show();
        }

        private void iconButtonDashboard_Click(object sender, System.EventArgs e)
        {
            panelControls.Controls.Clear();

            var stdc = new StudentDashboardControl(_user);
            panelControls.Controls.Add(stdc);
            stdc.Dock = DockStyle.Fill;
        }

        //retraction showing and hiding
        private void ButtonRetraction(List<Button> subButtons)
        {
            if (subButtons[0].Visible == true)
            {
                subButtons.ForEach(x => x.Visible = false);
            }
            else
            {
                subButtons.ForEach(x => x.Visible = true);
            }
        }
        private void iconButton1_Click(object sender, System.EventArgs e)
        {
            ButtonRetraction(new List<Button>
            {
                iconButtonSecurity,
                iconButtonInfo
            });
        }

        private void iconButtonInfo_Click(object sender, System.EventArgs e)
        {
            panelControls.Controls.Clear();

            var stInfo = new StudentInfo(_user);
            panelControls.Controls.Add(stInfo);
            stInfo.Dock = DockStyle.Fill;
        }

        private void iconButtonSecurity_Click(object sender, System.EventArgs e)
        {

        }
    }
}
