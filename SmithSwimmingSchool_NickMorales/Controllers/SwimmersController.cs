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
    public class SwimmersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SwimmersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Swimmers
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Swimmers.ToListAsync());
        }

        // GET: Swimmers/Details/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var swimmer = await _context.Swimmers
                .FirstOrDefaultAsync(m => m.SwimmerID == id);
            if (swimmer == null)
            {
                return NotFound();
            }

            return View(swimmer);
        }

        // GET: Swimmers/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
    {
        ViewBag.Genres = new SelectList(Enum.GetValues(typeof(Genre)));
        return View();
    }

    // POST: Swimmers/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("SwimmerID,Name,PhoneNumber,Email,Genre,BirthDate")] Swimmer swimmer)
    {
        if (ModelState.IsValid)
        {
            _context.Add(swimmer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewBag.Genres = new SelectList(Enum.GetValues(typeof(Genre)));
        return View(swimmer);
    }

        // GET: Swimmers/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var swimmer = await _context.Swimmers.FindAsync(id);
            if (swimmer == null)
            {
                return NotFound();
            }
            ViewBag.Genres = new SelectList(Enum.GetValues(typeof(Genre)));
            return View(swimmer);
        }

        // POST: Swimmers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("SwimmerID,Name,PhoneNumber,Email,Genre,BirthDate")] Swimmer swimmer)
        {
            if (id != swimmer.SwimmerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(swimmer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SwimmerExists(swimmer.SwimmerID))
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
            return View(swimmer);
        }

        // GET: Swimmers/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var swimmer = await _context.Swimmers
                .FirstOrDefaultAsync(m => m.SwimmerID == id);
            if (swimmer == null)
            {
                return NotFound();
            }

            return View(swimmer);
        }

        // POST: Swimmers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var swimmer = await _context.Swimmers.FindAsync(id);
            if (swimmer != null)
            {
                _context.Swimmers.Remove(swimmer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Swimmer")]
        public async Task<IActionResult> CoursesBySwimmer()
        {
            var currentUserId = User.Identity?.Name;
            var swimmer = await _context.Swimmers.FirstOrDefaultAsync(s => s.Email == currentUserId);
            var enrolledCourses = await _context.Enrollments
                    .Include(e => e.Course)
                    .ThenInclude(c => c.Coach) // Incluye el coach de cada curso
                    .Include(e => e.Group) // Incluye el grupo de cada curso
                    .Where(e => e.SwimmerID == swimmer.SwimmerID)
                    .ToListAsync();

                if (enrolledCourses == null || !enrolledCourses.Any())
                {
                    // Si no hay cursos matriculados, mostrar mensaje de advertencia
                    ViewData["WarningMessage"] = "No tienes cursos matriculados.";
                }

                return View(enrolledCourses);
        }
        [Authorize(Roles = "Swimmer")]
        public async Task <IActionResult> ViewReports(int id)
        {
            var reports = await _context.Reports.Where(r=>r.EnrollmentID == id)
                .ToListAsync();
            return View(reports);
        }
        private bool SwimmerExists(int id)
        {
            return _context.Swimmers.Any(e => e.SwimmerID == id);
        }
    }
}
