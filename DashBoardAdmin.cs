using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShortCourseTraining.Model;
using ShortCourseTraining.UserControls.User;

namespace ShortCourseTraining
{
    public partial class DashBoardAdmin : Form
    {
        private User _user = null;
        private List<Button> suButtons;
        public DashBoardAdmin(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void DashBoardAdmin_Load(object sender, EventArgs e)
        {
            UserBanner banner = new UserBanner(_user);
            banner.Dock = DockStyle.Top;
            panelOption.Controls.Add(banner);
            banner.Show();
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashBoardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            new WelcomeForm().Show();
        }

        //visible subButton for each button
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
        private void iconButtonCourse_Click(object sender, EventArgs e)
        {
            suButtons = new List<Button>
            {
                iconButtonAddCourses,
                iconButtonAllCourses
            };
            ButtonRetraction(suButtons);
        }
        private void iconButtonTeacher_Click(object sender, EventArgs e)
        {
            suButtons = new List<Button>
            {
                iconButtonAddTeacher,
                iconButtonAllTeacher
            };
            ButtonRetraction(suButtons);
        }

        private void iconButtonSubject_Click(object sender, EventArgs e)
        {
            suButtons = new List<Button>
            {
                iconButtonAddSubject,
                iconButtonAllSubject
            };
            ButtonRetraction(suButtons);
        }

        private void iconButtonStudent_Click(object sender, EventArgs e)
        {
            suButtons = new List<Button>
            {
                iconButtonAddStudent,
                iconButtonAllStudent
            };
            ButtonRetraction(suButtons);
        }

        private void iconButtonSetting_Click(object sender, EventArgs e)
        {
            suButtons = new List<Button>
            {
                iconButtonUserInfo,
                iconButtonPrivacy
            };
            ButtonRetraction(suButtons);
        }
    }
}
