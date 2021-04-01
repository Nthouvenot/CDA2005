using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TpFreelancer.Data;
using TpFreelancer.Models;

namespace TpFreelancer.Views
{
    public class JobsController : Controller
    {
        private readonly TpFreelancerContext _context;

        public JobsController(TpFreelancerContext context)
        {
            _context = context;
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobsModel.ToListAsync());
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobsModel = await _context.JobsModel
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (jobsModel == null)
            {
                return NotFound();
            }

            return View(jobsModel);
        }

        // GET: Jobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobId,JobState,JobTitle,JobStart,JobEnd,JobDescription,CustomerId")] JobsModel jobsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobsModel);
        }

        // GET: Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobsModel = await _context.JobsModel.FindAsync(id);
            if (jobsModel == null)
            {
                return NotFound();
            }
            return View(jobsModel);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobId,JobState,JobTitle,JobStart,JobEnd,JobDescription,CustomerId")] JobsModel jobsModel)
        {
            if (id != jobsModel.JobId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobsModelExists(jobsModel.JobId))
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
            return View(jobsModel);
        }

        // GET: Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobsModel = await _context.JobsModel
                .FirstOrDefaultAsync(m => m.JobId == id);
            if (jobsModel == null)
            {
                return NotFound();
            }

            return View(jobsModel);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobsModel = await _context.JobsModel.FindAsync(id);
            _context.JobsModel.Remove(jobsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobsModelExists(int id)
        {
            return _context.JobsModel.Any(e => e.JobId == id);
        }
    }
}
