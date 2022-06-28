using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTraining.Model
{
    internal class Company
    {
        public int ComID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Image Logo { get; set; }
        public User user { get; set; } //= user.role; //admin
        public string Password { get; set; } //admin password
        public string ActiveStatus { get; set; }

        public Company()
        {

        }

    }
}
