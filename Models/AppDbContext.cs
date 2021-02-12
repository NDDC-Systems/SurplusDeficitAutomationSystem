using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Report> Reports { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Value> Values { get; set; }
        public DbSet<TemplateFields> TemplateFields { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ReportFieldValues> ReportFieldValues { get; set; }
        public DbSet<ReportToContract> ReportsToContracts { get; set; }
    }
}
