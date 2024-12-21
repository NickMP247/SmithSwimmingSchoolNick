using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchool_NickMorales.Data;
using SmithSwimmingSchool_NickMorales.Models;

namespace SmithSwimmingSchool_NickMorales.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reports
        public async Task<IActionResult> Index()
        {
            
            var applicationDbContext = _context.Reports.Include(r => r.Enrollment).ThenInclude(r=>r.Swimmer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.Reports
                .Include(r => r.Enrollment)
                .FirstOrDefaultAsync(m => m.ReportID == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // GET: Reports/Create
        public IActionResult Create()
        {
            var enrollments = _context.Enrollments
                .Include(e => e.Swimmer)  // Incluir los nadadores
                .Select(e => new
                {
                    EnrollmentID = e.EnrollmentID,
                    SwimmerName = e.Swimmer != null ? e.Swimmer.Name : "Sin nadador"
                })
                .ToList();

            ViewData["EnrollmentID"] = new SelectList(enrollments, "EnrollmentID", "SwimmerName");
            return View();
        }

        // POST: Reports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportID,Description,EnrollmentID")] Report report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(report);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var enrollments = _context.Enrollments
                .Include(e => e.Swimmer)
                .Select(e => new
                {
                    EnrollmentID = e.EnrollmentID,
                    SwimmerName = e.Swimmer != null ? e.Swimmer.Name : "Sin nadador"
                })
                .ToList();

            ViewData["EnrollmentID"] = new SelectList(enrollments, "EnrollmentID", "SwimmerName", report.EnrollmentID);
            return View(report);
        }

        // GET: Reports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.Reports.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }

            var enrollments = _context.Enrollments
                .Include(e => e.Swimmer)  // Cargar el nadador asociado
                .Select(e => new
                {
                    EnrollmentID = e.EnrollmentID,
                    SwimmerName = e.Swimmer != null ? e.Swimmer.Name : "Sin nadador"
                })
                .ToList();

            ViewData["EnrollmentID"] = new SelectList(enrollments, "EnrollmentID", "SwimmerName", report.EnrollmentID);
            return View(report);
        }


        // POST: Reports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportID,Description,EnrollmentID")] Report report)
        {
            if (id != report.ReportID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(report);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportExists(report.ReportID))
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

            // Si hay un error, recargar la lista de nadadores para el desplegable
            var enrollments = _context.Enrollments
                .Include(e => e.Swimmer)
                .Select(e => new
                {
                    EnrollmentID = e.EnrollmentID,
                    SwimmerName = e.Swimmer != null ? e.Swimmer.Name : "Sin nadador"
                })
                .ToList();

            ViewData["EnrollmentID"] = new SelectList(enrollments, "EnrollmentID", "SwimmerName", report.EnrollmentID);
            return View(report);
        }


        // GET: Reports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var report = await _context.Reports
                .Include(r => r.Enrollment)
                .FirstOrDefaultAsync(m => m.ReportID == id);
            if (report == null)
            {
                return NotFound();
            }

            return View(report);
        }

        // POST: Reports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var report = await _context.Reports.FindAsync(id);
            if (report != null)
            {
                _context.Reports.Remove(report);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportExists(int id)
        {
            return _context.Reports.Any(e => e.ReportID == id);
        }
    }
}
