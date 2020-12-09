using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Models
{
    public class ReportFieldValuesRepository : IReportFieldValuesRepository
    {
        private readonly AppDbContext context;

        public ReportFieldValuesRepository(AppDbContext context)
        {
            this.context = context;
        }
        public ReportFieldValues Add(ReportFieldValues reportFieldValue)
        {
            context.ReportFieldValues.Add(reportFieldValue);
            context.SaveChanges();
            return reportFieldValue;
        }

        public ReportFieldValues Delete(int Id)
        {
            ReportFieldValues reportFieldValue = context.ReportFieldValues.Find(Id);
            if (reportFieldValue != null)
            {
                context.ReportFieldValues.Remove(reportFieldValue);
                context.SaveChanges();
            }
            return reportFieldValue;
        }

        public IEnumerable<ReportFieldValues> GetAllReportFieldValues()
        {
            return context.ReportFieldValues;
        }

        public ReportFieldValues GetReportFieldValue(int Id)
        {
            return context.ReportFieldValues.Find(Id);
        }

        public ReportFieldValues Update(ReportFieldValues reportFieldValueChanges)
        {
            var reportFieldValue = context.ReportFieldValues.Attach(reportFieldValueChanges);
            reportFieldValue.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return reportFieldValueChanges;
        }
    }
}
