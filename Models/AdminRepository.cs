using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext context;

        public AdminRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Admin Add(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
            return admin;
        }

        public Admin Delete(int AdminId)
        {
            Admin admin = context.Admins.Find(AdminId);
            if (admin != null)
            {
                context.Admins.Remove(admin);
                context.SaveChanges();
            }
            return admin;
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            return context.Admins;
        }

        public Admin GetAdmin(int AdminId)
        {
            return context.Admins.Find(AdminId);
        }

        public Admin Update(Admin adminChanges)
        {
            var report = context.Admins.Attach(adminChanges);
            report.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return adminChanges;
        }
    }
}
