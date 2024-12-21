using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchool_NickMorales.Data;
using SmithSwimmingSchool_NickMorales.Models;

namespace SmithSwimmingSchool_NickMorales.Controllers
{
    public class CoachesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoachesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Coaches
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Coachs.ToListAsync());
        }

        // GET: Coaches/Details/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coach = await _context.Coachs
                .FirstOrDefaultAsync(m => m.CoachID == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }

        // GET: Coaches/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coaches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("CoachID,Name,PhoneNumber,Email")] Coach coach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coach);
        }

        [Authorize(Roles = "Administrator, Coach")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                // Obtener el CoachID del usuario logueado si es un Coach
                if (User.IsInRole("Coach"))
                {
                    var currentUserId = User.Identity?.Name;
                    var coachs = await _context.Coachs.FirstOrDefaultAsync(c => c.Email == currentUserId);
                    if (coachs == null)
                    {
                        return NotFound();
                    }
                    id = coachs.CoachID;
                }
                else
                {
                    return NotFound();
                }
            }

            var coach = await _context.Coachs.FindAsync(id);
            if (coach == null)
            {
                return NotFound();
            }

            // Verificar si el usuario es un Coach y si está editando sus propios datos
            if (User.IsInRole("Coach") && User.Identity.Name != coach.Email)
            {
                return Forbid();
            }

            return View(coach);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator, Coach")]
        public async Task<IActionResult> Edit(int id, [Bind("CoachID,Name,PhoneNumber,Email")] Coach coach)
        {
            if (id != coach.CoachID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coach);
                    await _context.SaveChangesAsync();

                    // Redirigir según el rol del usuario
                    if (User.IsInRole("Administrator"))
                    {
                        return RedirectToAction("Index", "Coaches");
                    }
                    else if (User.IsInRole("Coach"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoachExists(coach.CoachID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return View(coach);
        }


        // GET: Coaches/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coach = await _context.Coachs
                .FirstOrDefaultAsync(m => m.CoachID == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }

        // POST: Coaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coach = await _context.Coachs.FindAsync(id);
            if (coach != null)
            {
                _context.Coachs.Remove(coach);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Coach")]
        public async Task <IActionResult> CoachCourses()
        {
            var currentId = User.Identity?.Name;
            var coach = await _context.Coachs.FirstOrDefaultAsync(c=>c.Email == currentId);
            var courses = await _context.Courses
                .Where(c=>c.CoachID==coach.CoachID).ToListAsync();

            if (courses == null || !courses.Any())
            {
                // Si no hay cursos matriculados, mostrar mensaje de advertencia
                ViewData["WarningMessage"] = "No tienes cursos asignados.";
            }

            return View(courses);
        }
        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> GroupCourse(int? id)
        {
            var groups = await _context.Groups
                .Join(_context.Enrollments, g => g.GroupID, e => e.GroupID, (g, e) => new { g, e })
                .Where(ge => ge.e.CourseID == id)
                .GroupBy(ge => ge.g)
                .Select(g => new
                {
                    Group = g.Key,
                    SwimmerCount = g.Count(ge => ge.e.SwimmerID != null)
                })
                .ToListAsync();

            ViewBag.GroupSwimmerCounts = groups.ToDictionary(g => g.Group.GroupID, g => g.SwimmerCount);

            return View(groups.Select(g => g.Group).ToList());
        }

        //Sacamos los nadadores de un grupo
        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> SwimmersGroups(int id)
        {
            var enrollments = await _context.Enrollments
                .Include(e => e.Swimmer)
                .Where(e => e.GroupID == id)
                .ToListAsync();

            return View(enrollments);
        }

        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> CreateReport(int idEnrollment)
        {
            var enrollment = await _context.Enrollments
                .Include(e => e.Swimmer)
                .FirstOrDefaultAsync(e => e.EnrollmentID == idEnrollment);

            if (enrollment == null)
            {
                return NotFound();
            }

            ViewData["EnrollmentID"] = idEnrollment;
            ViewData["SwimmerName"] = enrollment.Swimmer.Name;

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> CreateReport(int enrollmentID, string description)
        {
            if (ModelState.IsValid)
            {
                var report = new Report
                {
                    Description = description,
                    EnrollmentID = enrollmentID
                };

                _context.Reports.Add(report);
                await _context.SaveChangesAsync();

                // Redirigir a la vista de nadadores en el grupo
                var groupID = _context.Enrollments
                    .Where(e => e.EnrollmentID == enrollmentID)
                    .Select(e => e.GroupID)
                    .FirstOrDefault();

                return RedirectToAction("SwimmersGroups", new { id = groupID });
            }

            ViewData["EnrollmentID"] = enrollmentID;
            return View();
        }

        private bool CoachExists(int id)
        {
            return _context.Coachs.Any(e => e.CoachID == id);
        }
    }
}
