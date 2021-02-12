using System;
using System.Collections.Generic;
using System.Data;
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
        private AppDbContext db = new AppDbContext();
        private readonly IReportRepository _reportRepository;
        //private readonly IContractRepository _contractRepository;

        public ReportController(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }
        /*public ReportController(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }*/

        [Route("")]
        [Route("Index")]
        public ActionResult Index(int? id)
        {
            /*var viewModel = new ViewModel();
            viewModel.Reports = _reportRepository.GetAllReports();*/

            ViewModel myModel = new ViewModel();
            myModel.Reports = _reportRepository.GetAllReports();


            
            return View(myModel);
            
        }

        [Route("Details/{id?}")]
        public ViewResult Details(int? id)
        {
            /*ViewModel myModel = new ViewModel()
            {
                Report = _reportRepository.GetReport(id),
                PageTitle = "Report Details"
            };*/
            Report report = db.Reports.Find(id);
            var Results = from c in db.Contracts
                          select new
                          {
                              c.ContractId,
                              c.TemplateId,
                              c.ProviderId,
                              c.Balance
                          };
            var MyViewModel = new ReportViewModel();
            MyViewModel.ReportId = id.Value;
            MyViewModel.SubmitDate = report.SubmitDate;
            MyViewModel.Approved = report.Approved;
            MyViewModel.ApprovedDate = (DateTime)report.ApprovedDate;

            var MyContractViewModel = new List<ContractViewModel>();

            foreach (var item in Results)
            {
                MyContractViewModel.Add(new ContractViewModel { ContractId = item.ContractId, TemplateId = item.TemplateId, ProviderId = item.ProviderId, Balance = item.Balance });
            }

            MyViewModel.Contracts = MyContractViewModel;

            return View(MyViewModel);
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
