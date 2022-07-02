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
    }
}
