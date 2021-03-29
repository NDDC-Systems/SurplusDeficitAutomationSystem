using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SurplusDeficitAutomationSystem.Models;

namespace SurplusDeficitAutomationSystem.Controllers
{
    public class TemplateFieldsController : Controller
    {
        private readonly AppDbContext _context;

        public TemplateFieldsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TemplateFields
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.TemplateFields.Include(t => t.Field).Include(t => t.Template);
            return View(await appDbContext.ToListAsync());
        }

        // GET: TemplateFields/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var templateFields = await _context.TemplateFields
                .Include(t => t.Field)
                .Include(t => t.Template)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (templateFields == null)
            {
                return NotFound();
            }

            return View(templateFields);
        }

        // GET: TemplateFields/Create
        public IActionResult Create()
        {
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldName");
            ViewData["TemplateId"] = new SelectList(_context.Templates, "TemplateId", "TemplateName");
            return View();
        }

        // POST: TemplateFields/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TemplateId,FieldId")] TemplateFields templateFields)
        {
            if (ModelState.IsValid)
            {
                _context.Add(templateFields);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldId", templateFields.FieldId);
            ViewData["TemplateId"] = new SelectList(_context.Templates, "TemplateId", "TemplateId", templateFields.TemplateId);
            return View(templateFields);
        }

        // GET: TemplateFields/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var templateFields = await _context.TemplateFields.FindAsync(id);
            if (templateFields == null)
            {
                return NotFound();
            }
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldId", templateFields.FieldId);
            ViewData["TemplateId"] = new SelectList(_context.Templates, "TemplateId", "TemplateId", templateFields.TemplateId);
            return View(templateFields);
        }

        // POST: TemplateFields/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TemplateId,FieldId")] TemplateFields templateFields)
        {
            if (id != templateFields.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(templateFields);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemplateFieldsExists(templateFields.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldId", templateFields.FieldId);
            ViewData["TemplateId"] = new SelectList(_context.Templates, "TemplateId", "TemplateId", templateFields.TemplateId);
            return View(templateFields);
        }

        // GET: TemplateFields/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var templateFields = await _context.TemplateFields
                .Include(t => t.Field)
                .Include(t => t.Template)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (templateFields == null)
            {
                return NotFound();
            }

            return View(templateFields);
        }

        // POST: TemplateFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var templateFields = await _context.TemplateFields.FindAsync(id);
            _context.TemplateFields.Remove(templateFields);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemplateFieldsExists(int id)
        {
            return _context.TemplateFields.Any(e => e.Id == id);
        }
    }
}
