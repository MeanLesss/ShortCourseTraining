using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShortCourseTraining.Model;
using ShortCourseTraining.UserControls.DisplayControls;
using ShortCourseTraining.UserControls.User;

namespace ShortCourseTraining
{
    public partial class DashBoardAdmin : Form
    {
        private readonly User _user = null;
        OleDbConnection conn = null;
        string cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;

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

            var dashboard = new Dashboard();
            panelDisplayOption.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
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
            ButtonRetraction(new List<Button>
            {
                iconButtonAddCourses,
                iconButtonAllCourses
            });
        }
        private void iconButtonTeacher_Click(object sender, EventArgs e)
        {
            ButtonRetraction(new List<Button>
            {
                iconButtonAddTeacher,
                iconButtonAllTeacher
            });
        }

        private void iconButtonSubject_Click(object sender, EventArgs e)
        {
            ButtonRetraction(new List<Button>
            {
                iconButtonAddSubject,
                iconButtonAllSubject
            });
        }

        private void iconButtonStudent_Click(object sender, EventArgs e)
        {
            ButtonRetraction(new List<Button>
            {
                iconButtonAddStudent,
                iconButtonAllStudent
            });
        }

        //display panel
        private void DisplayControls(UserControl userControl)
        {
            var uc = userControl;
            panelDisplayOption.Controls.Clear();
            panelDisplayOption.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }
        private void iconButtonDashBoard_Click(object sender, EventArgs e)
        {
            DisplayControls(new Dashboard());
        }

        private void iconButtonAllCourses_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(cs);
            string query = @"select * from Courses";
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            DisplayControls(new DisplayAll(ds, 0));
        }

        private void iconButtonAddCourses_Click(object sender, EventArgs e)
        {
            DisplayControls(new AddCourses());
        }

        private void iconButtonAddTeacher_Click(object sender, EventArgs e)
        {
            DisplayControls(new AddTeacher(_user));
        }

        private void iconButtonAllTeacher_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(cs);
            string query = @"Select * from Users as u where u.Role_ID = 94";
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            DisplayControls(new DisplayAll(ds, 1));
        }

        private void iconButtonAddSubject_Click(object sender, EventArgs e)
        {
            DisplayControls(new AddSubject());
        }

        private void iconButtonAddStudent_Click(object sender, EventArgs e)
        {
            DisplayControls(new Add_Student());
        }
        private void iconButtonAllSubject_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(cs);
            string query = @"Select * from Subjects";
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            DisplayControls(new DisplayAll(ds, 2));
        }
        private void iconButtonAllStudent_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(cs);
            string query = @"Select * from Users as u where u.Role_ID = 88";
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            DisplayControls(new DisplayAll(ds, 3));
        }

    }
}
