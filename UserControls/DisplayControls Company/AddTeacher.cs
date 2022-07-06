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
    public partial class AddTeacher : UserControl
    {
        public AddTeacher()
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
                iconPictureBoxTeacher.Image = photo;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTeacherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContactAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonAddTeacher_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBirthPlace_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
