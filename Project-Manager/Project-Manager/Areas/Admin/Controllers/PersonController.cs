using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_Manager.Models;

namespace Project_Manager.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PersonController : Controller
    {
        private readonly SAGSContext _context;

        public PersonController(SAGSContext context)
        {
            _context = context;
        }

        // GET: Admin/Person
        public async Task<IActionResult> Index()
        {
            var sAGSContext = _context.People.Include(p => p.Group);
            return View(await sAGSContext.ToListAsync());
        }

        // GET: Admin/Person/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People
                .Include(p => p.Group)
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: Admin/Person/Create
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.PersonGroups, "GroupId", "GroupId");
            return View();
        }

        // POST: Admin/Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,FullName,JobTitle,MobilePhone,BusinessPhone,HomePhone,Address,Email,GroupId,UserId,Status,SortBy,Hrmid,PositionLevel")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.PersonGroups, "GroupId", "GroupId", person.GroupId);
            return View(person);
        }

        // GET: Admin/Person/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.PersonGroups, "GroupId", "GroupId", person.GroupId);
            return View(person);
        }

        // POST: Admin/Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,FullName,JobTitle,MobilePhone,BusinessPhone,HomePhone,Address,Email,GroupId,UserId,Status,SortBy,Hrmid,PositionLevel")] Person person)
        {
            if (id != person.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.PersonId))
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
            ViewData["GroupId"] = new SelectList(_context.PersonGroups, "GroupId", "GroupId", person.GroupId);
            return View(person);
        }
        //jQuery Ajax Modal
        // POST: Person/DeletePersonModal/
        [HttpPost]
        public JsonResult DeletePersonModal(int id)
        {
            bool result = false;

            var person = _context.People.FirstOrDefault(s => s.PersonId == id);
            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
                result = true;
            }
            return Json(result);
        }
        // GET: Admin/Person/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People
                .Include(p => p.Group)
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: Admin/Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.People.FindAsync(id);
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.People.Any(e => e.PersonId == id);
        }
    }
}
