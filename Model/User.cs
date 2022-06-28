using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTraining.Model
{
    internal class User
    {
        public int UserID { get; set; }
        public int ComID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Image Photo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }

        public User()
        {
                
        }
    }
}
