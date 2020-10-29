using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IReportRepository
    {
        Report GetReport(int ReportId);
        IEnumerable<Report> GetAllReports();
        Report Add(Report report);
        Report Update(Report reportChanges);
        Report Delete(int ReportId);
    }
}
