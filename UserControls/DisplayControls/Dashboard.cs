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
            
        }

        /*private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            var ptr = NativeMethod.CreateRoundRectRgn(15, 15, panel1.Width, panel1.Height, 40, 40);
            panel1.Region = Region.FromHrgn(ptr);
            NativeMethod.DeleteObject(ptr);
        }*/
    }
}
