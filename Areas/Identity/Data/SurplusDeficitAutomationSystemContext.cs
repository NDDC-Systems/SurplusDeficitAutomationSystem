using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SurplusDeficitAutomationSystem.Models;

namespace SurplusDeficitAutomationSystem.Data
{
    public class SurplusDeficitAutomationSystemContext : DbContext
    {
        //private readonly IReportRepository _reportRepository;
        public SurplusDeficitAutomationSystemContext(DbContextOptions<SurplusDeficitAutomationSystemContext> options)
            : base(options)
        {
            //_reportRepository = this.GetService<IReportRepository>();
        }

        //public DbSet<Report> Reports { get; set; }

        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }*/
    }
}
