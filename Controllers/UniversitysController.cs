using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranThiLanAnh114.Models;
using TranThiLanAnh114.Data;

namespace TranThiLanAnh114.Controllers
{
    public class UniversitysController : Controller
    {
        private readonly LanAnhDBContext _context;

        public UniversitysController(LanAnhDBContext context)
        {
            _context = context;
        }

        // GET: Universitys
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityTTLA114.ToListAsync());
        }

        // GET: Universitys/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTTLA114 = await _context.UniversityTTLA114
                .FirstOrDefaultAsync(m => m.UniversityID == id);
            if (universityTTLA114 == null)
            {
                return NotFound();
            }

            return View(universityTTLA114);
        }

        // GET: Universitys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Universitys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityID,UniversityName")] UniversityTTLA114 universityTTLA114)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityTTLA114);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityTTLA114);
        }

        // GET: Universitys/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTTLA114 = await _context.UniversityTTLA114.FindAsync(id);
            if (universityTTLA114 == null)
            {
                return NotFound();
            }
            return View(universityTTLA114);
        }

        // POST: Universitys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityID,UniversityName")] UniversityTTLA114 universityTTLA114)
        {
            if (id != universityTTLA114.UniversityID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityTTLA114);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityTTLA114Exists(universityTTLA114.UniversityID))
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
            return View(universityTTLA114);
        }

        // GET: Universitys/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityTTLA114 = await _context.UniversityTTLA114
                .FirstOrDefaultAsync(m => m.UniversityID == id);
            if (universityTTLA114 == null)
            {
                return NotFound();
            }

            return View(universityTTLA114);
        }

        // POST: Universitys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityTTLA114 = await _context.UniversityTTLA114.FindAsync(id);
            _context.UniversityTTLA114.Remove(universityTTLA114);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityTTLA114Exists(string id)
        {
            return _context.UniversityTTLA114.Any(e => e.UniversityID == id);
        }
    }
}
