using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IAdminRepository
    {
        Admin GetAdmin(int AdminId);
        IEnumerable<Admin> GetAllAdmins();
        Admin Add(Admin admin);
        Admin Update(Admin adminChanges);
        Admin Delete(int AdminId);
    }
}
