using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ShortCourseTraining.Model;

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
        public void SignUpUser(/*string fileName,*/User user)
        {
            string insertQuery = @"INSERT INTO Users([CompanyID],[Username],[Gender],[Password],[Description],[Phone],[Email],[Photo],[CreatedDate],[Status]) 
VALUES(@CompanyID,@Username,@Gender,@Password,@Description,@Phone,@Email,@Photo,@CreatedDate,@Status)";
            try
            {
                byte[] bytes = null;
                //bytes = GetImageBuff(fileName);
                bytes = GetImageBuff(user.Photo);

                conn = new OleDbConnection();
                conn.ConnectionString = cs;
                conn.Open();

                command = new OleDbCommand(insertQuery, conn);

                command.Parameters.Add("@CompanyID", OleDbType.TinyInt).Value = user.ComID;
                command.Parameters.Add("@Username", OleDbType.VarChar, 50).Value = user.Username;
                command.Parameters.Add("@Gender", OleDbType.VarChar, 6).Value = user.Gender;
                command.Parameters.Add("@Password", OleDbType.VarChar, 50).Value = user.Password;
                command.Parameters.Add("@Description", OleDbType.LongVarChar, 150).Value = user.Description;//description
                command.Parameters.Add("@Phone", OleDbType.VarChar,20).Value = user.PhoneNumber;//phone number
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
                //add the user first
                command.ExecuteNonQuery();
                //then add the user to the UserRole in DB as an insert query 'Admin' here
                //more query here

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
