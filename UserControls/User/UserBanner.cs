﻿using System.Windows.Forms;

namespace ShortCourseTraining.UserControls.User
{
    public partial class UserBanner : UserControl
    {
        private readonly Model.User _user;

        public UserBanner(Model.User user )
        {
            _user = user;
            InitializeComponent();
        }

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }


        private void UserBanner_Load(object sender, System.EventArgs e)
        {
            roundPictureBox1.Image = _user.Photo;
            labelUsername.Text = _user.Username;
            labelID.Text = _user.UserID.ToString();
        }
    }
}
