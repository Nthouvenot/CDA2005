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
    public class QuotesController : Controller
    {
        private readonly TpFreelancerContext _context;

        public QuotesController(TpFreelancerContext context)
        {
            _context = context;
        }

        // GET: Quotes
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuotesModels.ToListAsync());
        }

        // GET: Quotes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quotesModel = await _context.QuotesModels
                .FirstOrDefaultAsync(m => m.QuoteId == id);
            if (quotesModel == null)
            {
                return NotFound();
            }

            return View(quotesModel);
        }

        // GET: Quotes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuoteId,QuoteState,QuoteDate,QuoteAmount,QuoteFinalDate,QuoteFinalAmount,Jobid")] QuotesModel quotesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quotesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quotesModel);
        }

        // GET: Quotes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quotesModel = await _context.QuotesModels.FindAsync(id);
            if (quotesModel == null)
            {
                return NotFound();
            }
            return View(quotesModel);
        }

        // POST: Quotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuoteId,QuoteState,QuoteDate,QuoteAmount,QuoteFinalDate,QuoteFinalAmount,Jobid")] QuotesModel quotesModel)
        {
            if (id != quotesModel.QuoteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quotesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuotesModelExists(quotesModel.QuoteId))
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
            return View(quotesModel);
        }

        // GET: Quotes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quotesModel = await _context.QuotesModels
                .FirstOrDefaultAsync(m => m.QuoteId == id);
            if (quotesModel == null)
            {
                return NotFound();
            }

            return View(quotesModel);
        }

        // POST: Quotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quotesModel = await _context.QuotesModels.FindAsync(id);
            _context.QuotesModels.Remove(quotesModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuotesModelExists(int id)
        {
            return _context.QuotesModels.Any(e => e.QuoteId == id);
        }
    }
}
