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
using ShortCourseTraining.Database;
using ShortCourseTraining.Model;

namespace ShortCourseTraining
{
    public partial class AdminSignUpUC : UserControl
    {
        private FileInfo file;

        public AdminSignUpUC()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ButtonSignUp.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
                file = new FileInfo(of.FileName);
                Image photo = Image.FromFile(of.FileName);
                //product.Photo = photo;
                PictureBoxAdmin.Image = photo;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            DatabaseManager database = new DatabaseManager();

            //for company is use as an update query when there is a company that need to assign to
            if (textBoxPassword.Text == textBoxConfirmPass.Text)
            {
                User user = new User
                {
                    Username = textBoxUsername.Text,
                    ComID = 0,
                    Password = textBoxConfirmPass.Text,
                    Description = textBoxDescription.Text,
                    PhoneNumber = textBoxPhone.Text,
                    Email = textBoxEmail.Text,
                    Photo = PictureBoxAdmin.Image,
                    CreatedDate = DateTime.Now.Date,
                    Status = true
                };
                if (radioButtonMale.Checked)
                {
                    radioButtonFemale.Checked = false;
                    user.Gender = "Male";
                }

                if (radioButtonFemale.Checked)
                {
                    radioButtonMale.Checked = false;
                    user.Gender = "Female";
                }

                database.SignUpUser(/*file.FullName, */user);
                MessageBox.Show("Company Created");
            }
            else
            {
                MessageBox.Show("Password doesn't match");
            }
        }
        
    }
}
