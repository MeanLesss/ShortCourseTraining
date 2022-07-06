using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTraining.UserControls.DisplayControls
{
    public partial class AddSubject : UserControl
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void iconPictureBoxTeacher_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png";
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var file = new FileInfo(of.FileName);
                Image photo = Image.FromFile(of.FileName);
                //product.Photo = photo;
                iconPictureBoxSubject.Image = photo;
            }
        }
    }
}
