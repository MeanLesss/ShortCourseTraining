using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTraining.Model
{
    public class UserRole
    {
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public string RoleName { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
    }
}
