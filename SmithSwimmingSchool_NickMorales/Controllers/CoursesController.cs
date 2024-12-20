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
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Courses.Include(c => c.Coach);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Coach)
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            ViewData["CoachID"] = new SelectList(_context.Coachs, "CoachID", "CoachID");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CoachID,Title")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoachID"] = new SelectList(_context.Coachs, "CoachID", "CoachID", course.CoachID);
            return View(course);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["CoachID"] = new SelectList(_context.Coachs, "CoachID", "CoachID", course.CoachID);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CoachID,Title")] Course course)
        {
            if (id != course.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CourseID))
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
            ViewData["CoachID"] = new SelectList(_context.Coachs, "CoachID", "CoachID", course.CoachID);
            return View(course);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Coach)
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Enroll a swimmer in a course
        [Authorize(Roles = "Swimmer")]
        public async Task<IActionResult> EnrollSwimmer(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Devuelve un error 404 si el ID no es válido.
            }

            var currentUserId = User.Identity?.Name;
            Swimmer? swimmer = await _context.Swimmers.FirstOrDefaultAsync(s => s.Email == currentUserId);

            if (swimmer == null)
            {
                return NotFound(); // Devuelve un error si no se encuentra el nadador.
            }

            var currentCourse = await _context.Courses.FirstOrDefaultAsync(c => c.CourseID == id);

            if (currentCourse == null)
            {
                return NotFound(); // Devuelve un error si no se encuentra el curso.
            }

            // Pasar valores al ViewBag o ViewData.
            ViewData["CourseTitle"] = currentCourse.Title; // Solo para mostrarlo en la vista.
            ViewData["SwimmerName"] = swimmer.Name; // Solo para mostrarlo en la vista.
            ViewData["CourseID"] = currentCourse.CourseID; // ID del curso seleccionado (oculto en el formulario).
            ViewData["SwimmerID"] = swimmer.SwimmerID; // ID del nadador seleccionado (oculto en el formulario).

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Swimmer")]
        public async Task<IActionResult> EnrollSwimmer(Enrollment enrollment)
        {
            // Verificar si el nadador ya está inscrito en el curso
            var alreadyEnrolled = await _context.Enrollments
                .AnyAsync(e => e.CourseID == enrollment.CourseID && e.SwimmerID == enrollment.SwimmerID);

            if (alreadyEnrolled)
            {
                // Agregar un mensaje de error si ya está inscrito
                ModelState.AddModelError("", "You are already enrolled in this course.");

                // Recuperar la inscripción existente para mostrarla correctamente
                var existingEnrollment = await _context.Enrollments
                    .Include(e => e.Course)
                    .Include(e => e.Swimmer)
                    .FirstOrDefaultAsync(e => e.CourseID == enrollment.CourseID && e.SwimmerID == enrollment.SwimmerID);

                if (existingEnrollment != null)
                {
                    ViewData["CourseTitle"] = existingEnrollment.Course!.Title; // Mostrar el título del curso
                    ViewData["SwimmerName"] = existingEnrollment.Swimmer!.Name; // Mostrar el nombre del nadador
                }

                return View(existingEnrollment); // Mostrar la inscripción existente
            }

            // Crear la inscripción si no hay duplicados
            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();

            // Redirigir después de inscribir
            return RedirectToAction("Index");
        }


        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CourseID == id);
        }
    }
}
