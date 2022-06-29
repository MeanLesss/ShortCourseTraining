using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTraining.Model
{
    public class Company
    {
        public int ComID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyAddress { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Image Logo { get; set; }
        [Required]
        public User user { get; set; } //= user.role; //admin
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; } //admin password
        public bool ActiveStatus { get; set; }

        public Company()
        {

        }

    }
}
