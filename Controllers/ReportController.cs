using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurplusDeficitAutomationSystem.Areas;
using SurplusDeficitAutomationSystem.Models;
using SurplusDeficitAutomationSystem.ViewModels;

namespace SurplusDeficitAutomationSystem.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository _reportRepository;

        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }
        public ViewResult Index()
        {
            var model = _reportRepository.GetAllReports();
            return View(model);
        }

        public ViewResult Details()
        {
            IEnumerable<Report> reports = _reportRepository.GetAllReports();
            List<Report> reportList = reports.ToList();

            ReportDetailsViewModel reportDetailsViewModel = new ReportDetailsViewModel()
            {
                Report = reportList,
                PageTitle = "Report Details"
            };
            return View(reportDetailsViewModel);
        }

        [HttpGet]
        public ViewResult NewReport()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReport(Report report)
        {
            if (ModelState.IsValid)
            {
                Report newReport = _reportRepository.Add(report);
            }
            
            return View();
        }
    }
}
