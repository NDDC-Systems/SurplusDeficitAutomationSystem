using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
