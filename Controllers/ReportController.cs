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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewReport()
        {
            return View();
        }
    }
}
