﻿using System;
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
    public partial class UserAuthentication
    {
        OleDbConnection conn = null;
        OleDbCommand command = null;

        string cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;

        public User AdminAuthentication(string username , string password)
        {
            //List<User> users = new List<User>();
            conn = new OleDbConnection(cs);
            conn.Open();
            string authenticateQuery = @"SELECT * FROM Users as u WHERE u.Username = '" + username + "'" + "AND u.Password = '" + password + "'";
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

                    //read image from binary
                    byte[] imageBytes = (byte[])dt.Rows[0][8];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    user.Photo = Image.FromStream(ms);
                    ms.Flush();

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