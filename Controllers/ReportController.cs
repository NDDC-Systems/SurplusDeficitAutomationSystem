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
    [Route("Home")]
    public class ReportController : Controller
    {
        private readonly IReportRepository _reportRepository;

        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }

        [Route("")]
        [Route("Index")]
        public ViewResult Index()
        {
            ViewModel myModel = new ViewModel();
            myModel.Reports = _reportRepository.GetAllReports();
            return View(myModel);
            //var model = _reportRepository.GetAllReports();
            //return View(model);
        }

        [Route("Details/{id?}")]
        public ViewResult Details(int id)
        {
            ViewModel myModel = new ViewModel()
            {
                Report = _reportRepository.GetReport(id),
                PageTitle = "Report Details"
            };
            return View(myModel);
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
