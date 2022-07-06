using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public string Gender { get; set; } = "U/N";
        public string Description { get; set; } = "U/N";
        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = "U/N";
        [EmailAddress]
        public string Email { get; set; } = "U/N";
        public Image Photo { get; set; } 
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; } = false;
        public UserRole UserRole { get; set; }

        public int Classes { get; set; }
        public int Score { get; set; } = 0;
        public int FinalScore { get; set; } = 0;
        public int AbsentCount { get; set; }
        public int AttendanceCount { get; set; } = 0;
        public DateTime AttendanceDate { get; set; } = DateTime.Now.Date;
    }
}
