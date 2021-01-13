using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpFreelancer.Data;
using TpFreelancer.Models;

namespace TpFreelancer.Controllers
{
    public class CustomersCatsController : Controller
    {
        private readonly TpFreelancerContext _context;

        public CustomersCatsController(TpFreelancerContext context)
        {
            _context = context;
        }

        // GET: CustomersCats
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomersCatsModel.ToListAsync());
        }

        // GET: CustomersCats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersCats = await _context.CustomersCatsModel
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (customersCats == null)
            {
                return NotFound();
            }

            return View(customersCats);
        }

        // GET: CustomersCats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomersCats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,CatName,CatDescription")] CustomerCatsModel customersCats)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customersCats);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customersCats);
        }

        // GET: CustomersCats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersCats = await _context.CustomersCatsModel.FindAsync(id);
            if (customersCats == null)
            {
                return NotFound();
            }
            return View(customersCats);
        }

        // POST: CustomersCats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,CatName,CatDescription")] CustomerCatsModel customersCats)
        {
            if (id != customersCats.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customersCats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersCatsExists(customersCats.CatId))
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
            return View(customersCats);
        }

        // GET: CustomersCats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersCats = await _context.CustomersCatsModel
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (customersCats == null)
            {
                return NotFound();
            }

            return View(customersCats);
        }

        // POST: CustomersCats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customersCats = await _context.CustomersCatsModel.FindAsync(id);
            _context.CustomersCatsModel.Remove(customersCats);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersCatsExists(int id)
        {
            return _context.CustomersCatsModel.Any(e => e.CatId == id);
        }
    }
}
