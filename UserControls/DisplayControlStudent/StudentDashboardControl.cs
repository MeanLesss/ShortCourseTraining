using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShortCourseTraining.UserControls.DisplayControls.Cards;

namespace ShortCourseTraining.UserControls.DisplayControlStudent
{
    public partial class StudentDashboardControl : UserControl
    {
        private readonly Model.User _user; 
        public StudentDashboardControl(Model.User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void StudentDashboardControl_Load(object sender, EventArgs e)
        {

            var score = new StaticCountCard("Score", _user.Score);
            score.BackColor = Color.Chocolate;

            var absent = new StaticCountCard("Absent", _user.AbsentCount);
            absent.BackColor = Color.CornflowerBlue;

            var exam = new StaticCountCard("Exam", _user.FinalScore);
            exam.BackColor = Color.White;

            var classes = new StaticCountCard("Classes", _user.Classes);
            classes.BackColor = Color.Orange;

            flowLayoutPanelCards.Controls.Add(score);
            flowLayoutPanelCards.Controls.Add(absent);
            flowLayoutPanelCards.Controls.Add(exam);
            flowLayoutPanelCards.Controls.Add(classes);
        }
    }
}
