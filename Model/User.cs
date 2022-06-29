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
    public class User
    {
        public int UserID { get; set; }
        public int ComID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
        public string  Gender { get; set; }
        public string Description { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Image Photo { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public UserRole UserRole { get; set; }
    }
}
