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
using ShortCourseTraining.UserControls.DisplayControls.Cards;

namespace ShortCourseTraining.UserControls.DisplayControls
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var teacherStatic = new StaticCountCard("Teacher",12);
            var studentStatic = new StaticCountCard("Student",1000);
            var onlineStatic = new StaticCountCard("Online",20);
            flowLayoutStatic.Controls.Add(teacherStatic);
            flowLayoutStatic.Controls.Add(studentStatic);
            flowLayoutStatic.Controls.Add(onlineStatic);
            teacherStatic.Show();
            studentStatic.Show();
            onlineStatic.Show();
        }
    }
}
