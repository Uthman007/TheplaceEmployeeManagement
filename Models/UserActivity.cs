using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheplaceEmployeeManagement.Models
{
    public class UserActivity
    {
        public string? CreatedById { get; set; }
        public DateTime CreatedOn { get; set;}

        public string? ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
