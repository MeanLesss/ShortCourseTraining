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
        public string CanRead { get; set; }
        public string CanWrite { get; set; }
        public string CanUpdate { get; set; }
        public string CanDelete { get; set; }
    }
}
