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
    [Route("Template")]
    public class TemplateController : Controller
    {
        private readonly ITemplateRepository _templateRepository;
        //private readonly IFieldRepository _fieldRepository;
        //private readonly ITemplateFieldsRepository _templateFieldsRepository;
        public TemplateController(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
            //_fieldRepository = fieldRepository;
            //_templateFieldsRepository = templateFieldsRepository;
        }

        [Route("")]
        [Route("Index")]
        public ViewResult Index()
        {
            ViewModel myModel = new ViewModel();
            myModel.Templates = _templateRepository.GetAllTemplates();
            //myModel.Fields = _fieldRepository.GetAllFields();
            //myModel.TemplateFields = _templateFieldsRepository.GetAllTemplateFields();
            return View(myModel);
            //var model = _reportRepository.GetAllReports();
            //return View(model);
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

        /*[HttpGet]
        public ViewResult NewField()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewField(Field field)
        {
            if (ModelState.IsValid)
            {
                Field newField = _fieldRepository.Add(field);
            }

            return View();
        }
        [HttpGet]
        public ViewResult NewTemplateField()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewTemplateField (TemplateFields templateField)
        {
            if (ModelState.IsValid)
            {
                TemplateFields newTemplateField = _templateFieldsRepository.Add(templateField);
            }

            return View();
        }*/
    }
}
