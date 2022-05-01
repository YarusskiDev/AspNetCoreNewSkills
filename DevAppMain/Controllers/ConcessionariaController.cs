using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevAppMain.Areas.Identity.Data;
using DevAppMain.ViewModels;

namespace DevAppMain.Controllers
{
    public class ConcessionariaController : Controller
    {
        private readonly DevAppContextIdentity _context;

        public ConcessionariaController(DevAppContextIdentity context)
        {
            _context = context;
        }

        // GET: Concessionaria
        public async Task<IActionResult> Index()
        {
            return View(await _context.ConcessionariaViewModel.ToListAsync());
        }

        // GET: Concessionaria/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concessionariaViewModel = await _context.ConcessionariaViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concessionariaViewModel == null)
            {
                return NotFound();
            }

            return View(concessionariaViewModel);
        }

        // GET: Concessionaria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Concessionaria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] ConcessionariaViewModel concessionariaViewModel)
        {
            if (ModelState.IsValid)
            {
                concessionariaViewModel.Id = Guid.NewGuid();
                _context.Add(concessionariaViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(concessionariaViewModel);
        }

        // GET: Concessionaria/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concessionariaViewModel = await _context.ConcessionariaViewModel.FindAsync(id);
            if (concessionariaViewModel == null)
            {
                return NotFound();
            }
            return View(concessionariaViewModel);
        }

        // POST: Concessionaria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome")] ConcessionariaViewModel concessionariaViewModel)
        {
            if (id != concessionariaViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concessionariaViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConcessionariaViewModelExists(concessionariaViewModel.Id))
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
            return View(concessionariaViewModel);
        }

        // GET: Concessionaria/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concessionariaViewModel = await _context.ConcessionariaViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concessionariaViewModel == null)
            {
                return NotFound();
            }

            return View(concessionariaViewModel);
        }

        // POST: Concessionaria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var concessionariaViewModel = await _context.ConcessionariaViewModel.FindAsync(id);
            _context.ConcessionariaViewModel.Remove(concessionariaViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcessionariaViewModelExists(Guid id)
        {
            return _context.ConcessionariaViewModel.Any(e => e.Id == id);
        }
    }
}
