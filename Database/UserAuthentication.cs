using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using ShortCourseTraining.Model;

namespace ShortCourseTraining.Database
{
    public class UserAuthentication
    {
        OleDbConnection conn = null;
        OleDbCommand command = null;

        string cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;

        public User AdminAuthentication(string username, string password)
        {
            //List<User> users = new List<User>();

            /*SELECT * FROM Users as u 
            INNER JOIN UserRole AS UR
             ON UR.UserID = u.ID
            WHERE u.Username =  'mean'  AND u.Password =  '123' AND UR.Role = 'Admin';
            */
            conn = new OleDbConnection(cs);
            conn.Open();
            string authenticateQuery = @"SELECT * FROM Users as u
INNER JOIN UserRole AS UR
ON UR.UserID = u.ID
WHERE u.Username = '" + username + "'" + "AND u.Password = '" + password + "' AND UR.Role = 'Admin'";
            User user = new User();
            try
            {
                command = new OleDbCommand(authenticateQuery, conn);

                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    user.UserID = (int)dt.Rows[0][0];
                    user.ComID = (int)dt.Rows[0][1];
                    user.Username = dt.Rows[0][2].ToString();
                    user.Gender = dt.Rows[0][3].ToString();
                    user.Password = dt.Rows[0][4].ToString();
                    user.Description = dt.Rows[0][5].ToString();
                    user.PhoneNumber = dt.Rows[0][6].ToString();
                    user.Email = dt.Rows[0][7].ToString();

                    //read Image form binary
                    if (dt.Rows[0][8].GetType() == typeof(byte))
                    {
                        byte[] imageBytes = (byte[])dt.Rows[0][8];
                        MemoryStream ms = new MemoryStream(imageBytes);
                        user.Photo = Image.FromStream(ms);
                        ms.Flush();
                    }
                    else
                    {
                        user.Photo = null;
                    }

                    user.CreatedDate = (DateTime)dt.Rows[0][9];
                    user.Status = (bool)dt.Rows[0][10];

                }
                else
                {
                    user = null;
                }

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return user;
        }


        public User STAuthentication(string username, string password)
        {
            //List<User> users = new List<User>();

            /*SELECT * FROM Users as u 
            INNER JOIN UserRole AS UR
             ON UR.UserID = u.ID
            WHERE u.Username =  'mean'  AND u.Password =  '123' AND UR.Role = 'Admin';
            */
            conn = new OleDbConnection(cs);
            conn.Open();
            string authenticateQuery = @"SELECT * FROM Users as u
INNER JOIN UserRole AS UR
ON UR.UserID = u.ID
WHERE u.Username = '" + username + "'" + "AND u.Password = '" + password + "' AND UR.Role = 'Student' OR UR.Role = 'Teacher'";
            User user = new User();
            try
            {
                command = new OleDbCommand(authenticateQuery, conn);

                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    user.UserID = (int)dt.Rows[0][0];
                    user.ComID = (int)dt.Rows[0][1];
                    user.Username = dt.Rows[0][2].ToString();
                    user.Gender = dt.Rows[0][3].ToString();
                    user.Password = dt.Rows[0][4].ToString();
                    user.Description = dt.Rows[0][5].ToString();
                    user.PhoneNumber = dt.Rows[0][6].ToString();
                    user.Email = dt.Rows[0][7].ToString();

                    //read Image form binary
                    if (dt.Rows[0][8].GetType() == typeof(byte))
                    {
                        byte[] imageBytes = (byte[])dt.Rows[0][8];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    user.Photo = Image.FromStream(ms);
                    ms.Flush();
                    }
                    else
                    {
                        user.Photo = null;
                    }

                    user.CreatedDate = (DateTime)dt.Rows[0][9];
                    user.Status = (bool)dt.Rows[0][10];

                }
                else
                {
                    user = null;
                }

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return user;
        }
    }

}
