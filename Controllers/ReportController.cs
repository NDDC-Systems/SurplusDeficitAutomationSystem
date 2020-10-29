using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurplusDeficitAutomationSystem.Models;

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
