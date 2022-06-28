using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShortCourseTraining.Database
{
    public class DatabaseManager
    {
        OleDbConnection conn = null;
        OleDbCommand command = null;

        string cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;




        private byte[] GetImageBuff(string fileName)
        {
            Image img = Image.FromFile(fileName);
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

        public void SignUpCompany(string fileName)
        {
            string insertQuery = @"INSERT INTO Users([CompanyName],[CompanyAddress],[CompanyPhone],[CompanyEmail],[Logo],[AdminUserID],
[AdminUserPass],[CompanyStatus]) VALUES(@CompanyName,@CompanyAddress,@CompanyPhone,@CompanyEmail,@Logo,@AdminUserID,@AdminUserPass,@CompanyStatus)";
            try
            {
                byte[] bytes = null; 
                bytes = GetImageBuff(fileName);

                conn.Open();
                command = new OleDbCommand(insertQuery, conn);

                /*Random random = new Random();
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = textBoxUsername.Text;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = textBoxPassword.Text;
                command.Parameters.Add("@IPAddress", SqlDbType.NVarChar, 15).Value = IPAddressGenerator();
                command.Parameters.Add("@Port", SqlDbType.Int).Value = random.Next(30, 3000);
                command.Parameters.Add("@Email", SqlDbType.NVarChar, textBoxemail.TextLength).Value = textBoxemail.Text;
                command.Parameters.Add("@UserImage", SqlDbType.Image, bytes.Length).Value = bytes;
                if (textBoxPassword.Text == textBoxConfirmPass.Text)
                {
                    comm.ExecuteNonQuery();
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

        public void SignUpUser(string fileName)
        {
            string insertQuery = @"INSERT INTO Companies() VALUES()";
            try
            {
                byte[] bytes = null;
                bytes = GetImageBuff(fileName);

                conn.Open();
                command = new OleDbCommand(insertQuery, conn);

                /*Random random = new Random();
                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = textBoxUsername.Text;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = textBoxPassword.Text;
                command.Parameters.Add("@IPAddress", SqlDbType.NVarChar, 15).Value = IPAddressGenerator();
                command.Parameters.Add("@Port", SqlDbType.Int).Value = random.Next(30, 3000);
                command.Parameters.Add("@Email", SqlDbType.NVarChar, textBoxemail.TextLength).Value = textBoxemail.Text;
                command.Parameters.Add("@UserImage", SqlDbType.Image, bytes.Length).Value = bytes;
                if (textBoxPassword.Text == textBoxConfirmPass.Text)
                {
                    comm.ExecuteNonQuery();
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

    }
}
