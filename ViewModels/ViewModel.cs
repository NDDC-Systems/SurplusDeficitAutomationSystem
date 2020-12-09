using SurplusDeficitAutomationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.ViewModels
{
    public class ViewModel
    {
        public Report Report { get; set; }
        public IEnumerable<Report> Reports { get; set; }
        public Template Template { get; set; }
        public IEnumerable<Template> Templates { get; set; }
        public Contract Contract { get; set; }
        public IEnumerable<Contract> Contracts { get; set; }
        public Admin Admin { get; set; }
        public IEnumerable<Admin> Admins { get; set; }
        public Provider Provider { get; set; }
        public IEnumerable<Provider> Providers { get; set; }
        public User User { get; set; }
        public IEnumerable<User> Users { get; set; }
        public Field Field { get; set; }
        public IEnumerable<Field> Fields { get; set; }
        public TemplateFields TemplateField { get; set; }
        public IEnumerable<TemplateFields> TemplateFields { get; set; }
        public Value Value { get; set; }
        public IEnumerable<Value> Values { get; set; }
        public ReportFieldValues ReportFieldValue { get; set; }
        public IEnumerable<ReportFieldValues> ReportFieldValues { get; set; }
        public string PageTitle { get; set; }
    }
}
