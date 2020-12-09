using Microsoft.AspNetCore.Mvc;
using SurplusDeficitAutomationSystem.Models;
using SurplusDeficitAutomationSystem.ViewModels;
using SurplusDeficitAutomationSystem.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurplusDeficitAutomationSystem.Controllers
{
    [Route("TemplateFields")]
    public class TemplateFieldController : Controller
    {
        private readonly ITemplateFieldsRepository _templateFieldsRepository;

        public TemplateFieldController(ITemplateFieldsRepository templateFieldsRepository)
        {
            _templateFieldsRepository = templateFieldsRepository;

        }

        [Route("")]
        [Route("Index")]
        public ViewResult Index()
        {
            ViewModel myModel = new ViewModel();
            myModel.TemplateFields = _templateFieldsRepository.GetAllTemplateFields();
            return View(myModel);
        }

        [HttpGet]
        public ViewResult NewTemplateField()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewTemplateField(TemplateFields templateField)
        {
            if (ModelState.IsValid)
            {
                TemplateFields newTemplateField = _templateFieldsRepository.Add(templateField);
            }

            return View();
        }

    }
}
