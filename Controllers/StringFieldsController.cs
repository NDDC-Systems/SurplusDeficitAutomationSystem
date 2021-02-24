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
    public class StringFieldsController : Controller
    {
        private readonly AppDbContext _context;

        public StringFieldsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StringFields
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.StringFields.Include(s => s.Field);
            return View(await appDbContext.ToListAsync());
        }

        // GET: StringFields/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stringField = await _context.StringFields
                .Include(s => s.Field)
                .FirstOrDefaultAsync(m => m.StringFieldId == id);
            if (stringField == null)
            {
                return NotFound();
            }

            return View(stringField);
        }

        // GET: StringFields/Create
        public IActionResult Create()
        {
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldId");
            return View();
        }

        // POST: StringFields/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StringFieldId,FieldId,StringValue")] StringField stringField)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stringField);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldId", stringField.FieldId);
            return View(stringField);
        }

        // GET: StringFields/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stringField = await _context.StringFields.FindAsync(id);
            if (stringField == null)
            {
                return NotFound();
            }
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldId", stringField.FieldId);
            return View(stringField);
        }

        // POST: StringFields/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StringFieldId,FieldId,StringValue")] StringField stringField)
        {
            if (id != stringField.StringFieldId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stringField);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StringFieldExists(stringField.StringFieldId))
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
            ViewData["FieldId"] = new SelectList(_context.Fields, "FieldId", "FieldId", stringField.FieldId);
            return View(stringField);
        }

        // GET: StringFields/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stringField = await _context.StringFields
                .Include(s => s.Field)
                .FirstOrDefaultAsync(m => m.StringFieldId == id);
            if (stringField == null)
            {
                return NotFound();
            }

            return View(stringField);
        }

        // POST: StringFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stringField = await _context.StringFields.FindAsync(id);
            _context.StringFields.Remove(stringField);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StringFieldExists(int id)
        {
            return _context.StringFields.Any(e => e.StringFieldId == id);
        }
    }
}
