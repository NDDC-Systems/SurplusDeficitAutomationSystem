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
    public class TemplateController : Controller
    {
        private readonly ITemplateRepository _templateRepository;
        public TemplateController(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }
        public ViewResult Index()
        {
            var model = _templateRepository.GetAllTemplates();
            return View(model);
        }

        [HttpGet]
        public ViewResult NewTemplate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewTemplate(Template template)
        {
            if (ModelState.IsValid)
            {
                Template newTemplate = _templateRepository.Add(template);
            }

            return View();
        }
    }
}
