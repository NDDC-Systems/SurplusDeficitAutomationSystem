using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ReportRepository : IReportRepository
    {
        private List<Report> _reportList;

        public ReportRepository()
        {
            _reportList = new List<Report>()
            {
                new Report() { ReportId = 1, ContractId = 2, SubmitDate = new DateTime(2020, 9, 20), Provider = "Bay Medical", Approved = true, Admin = "John Smith", ApprovedDate = new DateTime(2020, 9, 28)},
                new Report() { ReportId = 2, ContractId = 2, SubmitDate = new DateTime(2020, 10, 20), Provider = "Bay Medical", Approved = false, Admin = "John Smith", ApprovedDate = null},
                new Report() { ReportId = 3, ContractId = 1, SubmitDate = new DateTime(2020, 10, 20), Provider = "UF Health", Approved = true, Admin = "Jane Doe", ApprovedDate = new DateTime(2020, 10, 28)}
            };
        }
        public Report Add(Report report)
        {
            report.ReportId = _reportList.Max(r => r.ReportId) + 1;
            _reportList.Add(report);
            return report;
        }

        public Report Delete(int id)
        {
            Report report = _reportList.FirstOrDefault(r => r.ReportId == id);
            if (report != null)
            {
                _reportList.Remove(report);
            }
            return report;
        }
          
        public IEnumerable<Report> GetAllReports()
        {
            return _reportList;
        }
        public Report GetReport(int ReportId)
        {
            return _reportList.FirstOrDefault(r => r.ReportId == ReportId);
        }

        public Report Update(Report reportChanges)
        {
            Report report = _reportList.FirstOrDefault(r => r.ReportId == reportChanges.ReportId);
            if (report != null)
            {
                report.ReportId = reportChanges.ReportId;
                report.ContractId = reportChanges.ContractId;
                report.SubmitDate = reportChanges.SubmitDate;
                report.Provider = reportChanges.Provider;
                report.Approved = reportChanges.Approved;
                report.Admin = reportChanges.Admin;
                report.ApprovedDate = reportChanges.ApprovedDate;
            }
            return report;
        }
    }
}
