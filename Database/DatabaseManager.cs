using MimeKit;
using ShortCourseTraining.Model;
using System;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using MailKit.Net.Smtp;


namespace ShortCourseTraining.Database
{
    public class DatabaseManager
    {
        OleDbConnection conn = null;
        OleDbCommand command = null;

        string cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;
        
        public void SignUpCompany(string fileName)
        {
            string insertQuery = @"INSERT INTO Companies([CompanyName],[CompanyAddress],[CompanyPhone],[CompanyEmail],[Logo],[AdminUserID],
[AdminUserPass],[CompanyStatus]) VALUES(@CompanyName,@CompanyAddress,@CompanyPhone,@CompanyEmail,@Logo,@AdminUserID,@AdminUserPass,@CompanyStatus)";
            try
            {
                byte[] bytes = null; 
                //bytes = GetImageBuff(fileName);

                conn.Open();
                command = new OleDbCommand(insertQuery, conn);

                /*Random random = new Random();
                command.Parameters.Add("@Username", oleDbType:, 50).Value = textBoxUsername.Text;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = textBoxPassword.Text;
                command.Parameters.Add("@IPAddress", SqlDbType.NVarChar, 15).Value = IPAddressGenerator();
                command.Parameters.Add("@Port", SqlDbType.Int).Value = random.Next(30, 3000);
                command.Parameters.Add("@Email", SqlDbType.NVarChar, textBoxemail.TextLength).Value = textBoxemail.Text;
                command.Parameters.Add("@UserImage", SqlDbType.Image, bytes.Length).Value = bytes;
                if (textBoxPassword.Text == textBoxConfirmPass.Text)
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Password doesn't match");
                    conn.Close();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Company register failed : " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        [Obsolete]
        public void SignUpUser(/*string fileName,*/User user)//add admin
        {
            string insertQuery = @"INSERT INTO Users([CompanyID],[Username],[Gender],[Password],[Description],[Phone],[Email],[Photo],[CreatedDate],[Status],[Role_ID]) 
VALUES(@CompanyID,@Username,@Gender,@Password,@Description,@Phone,@Email,@Photo,@CreatedDate,@Status,@Role_ID)";
            try
            {
                byte[] bytes = null;
                //bytes = GetImageBuff(fileName);
                bytes = GetImageBuff(user.Photo);

                using (conn = new OleDbConnection(cs))
                {
                    conn.Open();
                    command = new OleDbCommand(insertQuery, conn);

                    command.Parameters.Add("@CompanyID", OleDbType.TinyInt).Value = user.ComID;
                    command.Parameters.Add("@Username", OleDbType.VarChar, 50).Value = user.Username;
                    command.Parameters.Add("@Gender", OleDbType.VarChar, 6).Value = user.Gender;
                    command.Parameters.Add("@Password", OleDbType.VarChar, 50).Value = user.Password;
                    command.Parameters.Add("@Description", OleDbType.LongVarChar, 150).Value = user.Description;//description
                    command.Parameters.Add("@Phone", OleDbType.VarChar, 20).Value = user.PhoneNumber;//phone number
                    command.Parameters.Add("@Email", OleDbType.VarChar, user.Email.Length).Value = user.Email;
                    if (user.Photo == null)
                    {
                        command.Parameters.Add("@Photo", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.Add("@Photo", OleDbType.LongVarBinary, bytes.Length).Value = bytes;
                    }
                    command.Parameters.Add("@CreatedDate", OleDbType.DBDate).Value = DateTime.Now.Date;
                    command.Parameters.Add("@Status", OleDbType.TinyInt, 1).Value = user.Status;
                    command.Parameters.Add("@Role_ID", OleDbType.TinyInt, 100).Value = 93;
                    //add the user first
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("User register failed : " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        [Obsolete]
        public void SignUpStudent(/*string fileName,*/User user)//add admin
        {
            string insertQuery = @"INSERT INTO Users([CompanyID],[Username],[Gender],[Password],[Description],[Phone],[Email],[Photo],[CreatedDate],[Status],[Role_ID]) 
VALUES(@CompanyID,@Username,@Gender,@Password,@Description,@Phone,@Email,@Photo,@CreatedDate,@Status,@Role_ID)";
            try
            {
                byte[] bytes = null;
                //bytes = GetImageBuff(fileName);
                bytes = GetImageBuff(user.Photo);

                using (conn = new OleDbConnection(cs))
                {
                    conn.Open();
                    command = new OleDbCommand(insertQuery, conn);

                    command.Parameters.Add("@CompanyID", OleDbType.TinyInt).Value = user.ComID;
                    command.Parameters.Add("@Username", OleDbType.VarChar, 50).Value = user.Username;
                    command.Parameters.Add("@Gender", OleDbType.VarChar, 6).Value = user.Gender;
                    command.Parameters.Add("@Password", OleDbType.VarChar, 50).Value = user.Password;
                    command.Parameters.Add("@Description", OleDbType.LongVarChar, 150).Value = user.Description;//description
                    command.Parameters.Add("@Phone", OleDbType.VarChar, 20).Value = user.PhoneNumber;//phone number
                    command.Parameters.Add("@Email", OleDbType.VarChar, user.Email.Length).Value = user.Email;
                    if (user.Photo == null)
                    {
                        command.Parameters.Add("@Photo", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.Add("@Photo", OleDbType.LongVarBinary, bytes.Length).Value = bytes;
                    }
                    command.Parameters.Add("@CreatedDate", OleDbType.DBDate).Value = DateTime.Now.Date;
                    command.Parameters.Add("@Status", OleDbType.TinyInt, 1).Value = user.Status;
                    command.Parameters.Add("@Role_ID", OleDbType.TinyInt, 100).Value = 88;
                    //add the user first
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User register failed : " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        [Obsolete]
        public void SignUpTeacher(/*string fileName,*/User user)//add admin
        {
            string insertQuery = @"INSERT INTO Users([CompanyID],[Username],[Gender],[Password],[Description],[Phone],[Email],[Photo],[CreatedDate],[Status],[Role_ID],[TeacherSubject]) 
VALUES(@CompanyID,@Username,@Gender,@Password,@Description,@Phone,@Email,@Photo,@CreatedDate,@Status,@Role_ID,@TeacherSubject)";
            try
            {
                byte[] bytes = null;
                //bytes = GetImageBuff(fileName);
                bytes = GetImageBuff(user.Photo);

                using (conn = new OleDbConnection(cs))
                {
                    conn.Open();
                    command = new OleDbCommand(insertQuery, conn);

                    command.Parameters.Add("@CompanyID", OleDbType.TinyInt).Value = user.ComID;
                    command.Parameters.Add("@Username", OleDbType.VarChar, 50).Value = user.Username;
                    command.Parameters.Add("@Gender", OleDbType.VarChar, 6).Value = user.Gender;
                    command.Parameters.Add("@Password", OleDbType.VarChar, 50).Value = user.Password;
                    command.Parameters.Add("@Description", OleDbType.LongVarChar, 150).Value = user.Description;//description
                    command.Parameters.Add("@Phone", OleDbType.VarChar, 20).Value = user.PhoneNumber;//phone number
                    command.Parameters.Add("@Email", OleDbType.VarChar, user.Email.Length).Value = user.Email;
                    if (user.Photo == null)
                    {
                        command.Parameters.Add("@Photo", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.Add("@Photo", OleDbType.LongVarBinary, bytes.Length).Value = bytes;
                    }
                    command.Parameters.Add("@CreatedDate", OleDbType.DBDate).Value = DateTime.Now.Date;
                    command.Parameters.Add("@Status", OleDbType.TinyInt, 1).Value = user.Status;
                    command.Parameters.Add("@Role_ID", OleDbType.TinyInt, 100).Value = 94; // 94 is teacher role
                    command.Parameters.Add("@TeacherSubject", OleDbType.VarChar, 40).Value = user.TeachingSubject;
                    //add the user first
                    command.ExecuteNonQuery();
                }
                SendingEmail(user.Email, user.Username, user.Password);
                System.Windows.Forms.MessageBox.Show("Teacher Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User register failed : " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void SendingEmail(string Email, string Username, string Password)
        {
            if (!string.IsNullOrEmpty(Email))
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("ShortCourseTraining", "kang.sokvimean.ks@gmail.com"));

                message.To.Add(MailboxAddress.Parse(Email));

                message.Subject = "Account Creation";

                message.Body = new TextPart("plain")
                {
                    Text = "You have successfully been registered for our Program, Please check the Information below : \n"
                           + " Username : " + Username + "\n Password : " + Password
                           + "\n Please change the given credentials as soon as possible"
                };
                SmtpClient client = new SmtpClient();

                try
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("kang.sokvimean.ks@gmail.com", "0767625958");

                    client.Send(message);

                    // MessageBox.Show("Confirmation Email Sent!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(" There was no give email address, so there will be no registration confirmation sent!");
            }
        }


        public void AddCourse(Course course)
        {
            string insertQuery = @"INSERT INTO Courses(Course_name,Subject_title,Course_Hours) VALUES(
@Course_name,@Subject_title,@Course_hours)";

            using (conn = new OleDbConnection(cs))
            {
                conn.Open();
                command = new OleDbCommand(insertQuery, conn);

                command.Parameters.Add("@Course_name", OleDbType.VarChar,50).Value = course.CourseName;
                command.Parameters.Add("@Subject_title", OleDbType.VarChar, 50).Value = course.SubjectTitle;
                command.Parameters.Add("@Course_hours", OleDbType.Integer,50).Value = course.CourseHours;
       
                command.ExecuteNonQuery();
            }
        }
        public void AddSubject(Subject subject)
        {

        }


        private byte[] GetImageBuff(Image photo/*string fileName*/)
        {
            //Image img = Image.FromFile(fileName);
            Image img = photo;
            int maxWidth = 300, maxHeight = 300;

            //Sizes were chosen arbitrarily
            double ratioX = (double)maxWidth / img.Width;
            double ratioY = (double)maxHeight / img.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);
            Image mi = new Bitmap(newWidth, newHeight);

            //picture in the memory
            Graphics g = Graphics.FromImage(mi);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();

            //a stream to input/output bytes from the memory
            mi.Save(ms, ImageFormat.Jpeg);
            ms.Flush();

            //bring all the buffer data to the stream
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);
            return buf;
        }

    }
}
//
//Insert into Subjects(Title, Start_date, End_date) Values(@Title, @Start_date, @End_date);