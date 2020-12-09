using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public interface IReportFieldValuesRepository
    {
        ReportFieldValues GetReportFieldValue(int Id);
        IEnumerable<ReportFieldValues> GetAllReportFieldValues();
        ReportFieldValues Add(ReportFieldValues reportFieldValue);
        ReportFieldValues Update(ReportFieldValues reportFieldValueChanges);
        ReportFieldValues Delete(int Id);
    }
}
