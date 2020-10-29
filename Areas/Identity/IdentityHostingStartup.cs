using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SurplusDeficitAutomationSystem.Data;

[assembly: HostingStartup(typeof(SurplusDeficitAutomationSystem.Areas.Identity.IdentityHostingStartup))]
namespace SurplusDeficitAutomationSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SurplusDeficitAutomationSystemContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityDb")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<SurplusDeficitAutomationSystemContext>();
            });
        }
    }
}