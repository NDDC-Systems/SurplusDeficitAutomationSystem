using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using SurplusDeficitAutomationSystem.Data;
using SurplusDeficitAutomationSystem.Models;

namespace SurplusDeficitAutomationSystem
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(_config.GetConnectionString("SurplusDeficitDb")));
            services.AddMvc().AddXmlDataContractSerializerFormatters();
            //services.AddTransient<IAdminRepository, AdminRepository>();
            //services.AddTransient<IBooleanFieldRepository, BooleanFieldRepository>();
            //services.AddTransient<IContractRepository, ContractRepository>();
            //services.AddTransient<IDateTimeFieldRepository, DateTimeFieldRepository>();
            //services.AddTransient<IFieldRepository, FieldRepository>();
            //services.AddTransient<IFloatFieldRepository, FloatFieldRepository>();
            //services.AddTransient<IIntFieldRepository, IntFieldRepository>();
            //services.AddTransient<IProviderRepository, ProviderRepository>();
            //services.AddTransient<IReportRepository, ReportRepository>();
            //services.AddTransient<IStringFieldRepository, StringFieldRepository>();
            services.AddTransient<ITemplateFieldsRepository, TemplateFieldsRepository>();
            services.AddTransient<ITemplateRepository, TemplateRepository>();
            //services.AddTransient<ITextFieldRepository, TextFieldRepository>();
            //services.AddTransient<IUserRepository, UserRepository>();
            //services.AddTransient<IValueRepository, ValueRepository>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
