using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;

namespace ShortCourseTraining
{
    public partial class AdminSignUpUC : UserControl
    {
        

        public AdminSignUpUC()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PictureBoxAdmin_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png";
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Image photo = Image.FromFile(of.FileName);
                //product.Photo = photo;
                PictureBoxAdmin.Image = photo;
            }
        }

        private void ButtonCompany_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
           
        }
    }
}
