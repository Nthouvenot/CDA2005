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
    public class CustomersController : Controller
    {
        private readonly TpFreelancerContext _context;

        public CustomersController(TpFreelancerContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomersModel.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersModel = await _context.CustomersModel
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customersModel == null)
            {
                return NotFound();
            }

            return View(customersModel);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerName,CustomerEmail,CatId")] CustomersModel customersModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customersModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customersModel);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersModel = await _context.CustomersModel.FindAsync(id);
            if (customersModel == null)
            {
                return NotFound();
            }
            return View(customersModel);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustomerName,CustomerEmail,CatId")] CustomersModel customersModel)
        {
            if (id != customersModel.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customersModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomersModelExists(customersModel.CustomerId))
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
            return View(customersModel);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customersModel = await _context.CustomersModel
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customersModel == null)
            {
                return NotFound();
            }

            return View(customersModel);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customersModel = await _context.CustomersModel.FindAsync(id);
            _context.CustomersModel.Remove(customersModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomersModelExists(int id)
        {
            return _context.CustomersModel.Any(e => e.CustomerId == id);
        }
    }
}
