using SurplusDeficitAutomationSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class SQLReportRepository : IReportRepository
    {
        private readonly SurplusDeficitAutomationSystemContext context;

        public SQLReportRepository(SurplusDeficitAutomationSystemContext context)
        {
            this.context = context;
        }
        public Report Add(Report report)
        {
            context.Reports.Add(report);
            context.SaveChanges();
            return report;
        }

        public Report Delete(int ReportId)
        {
            Report report = context.Reports.Find(ReportId);
            if (report != null)
            {
                context.Reports.Remove(report);
                context.SaveChanges();
            }
            return report;
        }

        public IEnumerable<Report> GetAllReports()
        {
            return context.Reports;
        }

        public Report GetReport(int ReportId)
        {
            return context.Reports.Find(ReportId);
        }

        public Report Update(Report reportChanges)
        {
            var report = context.Reports.Attach(reportChanges);
            report.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return reportChanges;
        }
    }
}
