using ShortCourseTraining.Database;
using ShortCourseTraining.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
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
        OleDbConnection conn = null;
        string cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;


        public AddSubject()
        {
            InitializeComponent();
        }
        private void AddSubject_Load(object sender, EventArgs e)
        {
            ReadData();
        }
        public void ReadData()
        {
            OleDbDataReader reader = null;
            try
            {
                conn = new OleDbConnection(cs);
                conn.Open();
                string query = @"Select Username from Users as u where u.Role_ID = 94";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();
                do
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            comboBoxTeacherName.Items.Add(reader.GetValue(i));
                        }
                    }
                } while (reader.NextResult());
            }

            finally
            {
                //close reader
                if (reader != null)
                {
                    reader.Close();
                }
                //close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
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


        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButtonAddSubject_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.SubjectName = textBoxSubjectTitle.Text;
            subject.StartDate = dateTimePickerStart.Value.Date;
            subject.EndDate = dateTimePickerEnd.Value.Date;

            new DatabaseManager().AddSubject(subject);
            MessageBox.Show("Subject successfully added!!");
        }
    }
}
