using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranThiLanAnh114.Data;
using TranThiLanAnh114.Models;

namespace TranThiLanAnh114.Controllers
{
    public class TTLA1114sController : Controller
    {
        private readonly LanAnhDBContext _context;

        public TTLA1114sController(LanAnhDBContext context)
        {
            _context = context;
        }

        // GET: TTLA1114s
        public async Task<IActionResult> Index()
        {
            return View(await _context.TTLA1114.ToListAsync());
        }

        // GET: TTLA1114s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTLA1114 = await _context.TTLA1114
                .FirstOrDefaultAsync(m => m.TTLAId == id);
            if (tTLA1114 == null)
            {
                return NotFound();
            }

            return View(tTLA1114);
        }

        // GET: TTLA1114s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TTLA1114s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TTLAId,TTLAName,TTLAGener")] TTLA1114 tTLA1114)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tTLA1114);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tTLA1114);
        }

        // GET: TTLA1114s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTLA1114 = await _context.TTLA1114.FindAsync(id);
            if (tTLA1114 == null)
            {
                return NotFound();
            }
            return View(tTLA1114);
        }

        // POST: TTLA1114s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TTLAId,TTLAName,TTLAGener")] TTLA1114 tTLA1114)
        {
            if (id != tTLA1114.TTLAId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tTLA1114);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TTLA1114Exists(tTLA1114.TTLAId))
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
            return View(tTLA1114);
        }

        // GET: TTLA1114s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTLA1114 = await _context.TTLA1114
                .FirstOrDefaultAsync(m => m.TTLAId == id);
            if (tTLA1114 == null)
            {
                return NotFound();
            }

            return View(tTLA1114);
        }

        // POST: TTLA1114s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tTLA1114 = await _context.TTLA1114.FindAsync(id);
            _context.TTLA1114.Remove(tTLA1114);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TTLA1114Exists(string id)
        {
            return _context.TTLA1114.Any(e => e.TTLAId == id);
        }
    }
}
