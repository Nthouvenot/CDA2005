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
    public class CustomerCatsModelsController : Controller
    {
        private readonly TpFreelancerContext _context;

        public CustomerCatsModelsController(TpFreelancerContext context)
        {
            _context = context;
        }

        // GET: CustomerCatsModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomersCatsModel.ToListAsync());
        }

        // GET: CustomerCatsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCatsModel = await _context.CustomersCatsModel
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (customerCatsModel == null)
            {
                return NotFound();
            }

            return View(customerCatsModel);
        }

        // GET: CustomerCatsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerCatsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,CatName,CatDescription")] CustomerCatsModel customerCatsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerCatsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerCatsModel);
        }

        // GET: CustomerCatsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCatsModel = await _context.CustomersCatsModel.FindAsync(id);
            if (customerCatsModel == null)
            {
                return NotFound();
            }
            return View(customerCatsModel);
        }

        // POST: CustomerCatsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,CatName,CatDescription")] CustomerCatsModel customerCatsModel)
        {
            if (id != customerCatsModel.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerCatsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerCatsModelExists(customerCatsModel.CatId))
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
            return View(customerCatsModel);
        }

        // GET: CustomerCatsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCatsModel = await _context.CustomersCatsModel
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (customerCatsModel == null)
            {
                return NotFound();
            }

            return View(customerCatsModel);
        }

        // POST: CustomerCatsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerCatsModel = await _context.CustomersCatsModel.FindAsync(id);
            _context.CustomersCatsModel.Remove(customerCatsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerCatsModelExists(int id)
        {
            return _context.CustomersCatsModel.Any(e => e.CatId == id);
        }
    }
}
