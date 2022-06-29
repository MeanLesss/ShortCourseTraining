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

namespace ShortCourseTraining
{
    public partial class TESTER : Form
    {
        private User user = null;
        public TESTER(User user)
        {
            InitializeComponent();
            this.user = user;
            iconPictureBox1.Image = user.Photo;

        }
    }
}
