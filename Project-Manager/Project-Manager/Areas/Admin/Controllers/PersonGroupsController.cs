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
    public class PersonGroupsController : Controller
    {
        private readonly SAGSContext _context;

        public PersonGroupsController(SAGSContext context)
        {
            _context = context;
        }

        // GET: Admin/PersonGroups
        public async Task<IActionResult> Index()
        {
            //var sAGSContext = _context.PersonGroups.Where(x => x.GroupId == 1);
            //return View(await sAGSContext.ToListAsync());
            return View(await _context.PersonGroups.ToListAsync());
        }
        public async Task<IActionResult> MenuPersonGroup()
        {
            //var sAGSContext = _context.PersonGroups.Where(x => x.GroupId == 1);
            //return View(await sAGSContext.ToListAsync());
            return PartialView(await _context.PersonGroups.ToListAsync());
        }

        // GET: Admin/PersonGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personGroup = await _context.PersonGroups
                .FirstOrDefaultAsync(m => m.GroupId == id);
            if (personGroup == null)
            {
                return NotFound();
            }

            return View(personGroup);
        }

        // GET: Admin/PersonGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PersonGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupId,GroupName,GroupDescription,Address,Phone,GroupLevel,Odr,GroupParentId,UserId,Status,GroupType")] PersonGroup personGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personGroup);
        }

        // GET: Admin/PersonGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personGroup = await _context.PersonGroups.FindAsync(id);
            if (personGroup == null)
            {
                return NotFound();
            }
            return View(personGroup);
        }

        // POST: Admin/PersonGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupId,GroupName,GroupDescription,Address,Phone,GroupLevel,Odr,GroupParentId,UserId,Status,GroupType")] PersonGroup personGroup)
        {
            if (id != personGroup.GroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonGroupExists(personGroup.GroupId))
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
            return View(personGroup);
        }

        // GET: Admin/PersonGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personGroup = await _context.PersonGroups
                .FirstOrDefaultAsync(m => m.GroupId == id);
            if (personGroup == null)
            {
                return NotFound();
            }

            return View(personGroup);
        }

        // POST: Admin/PersonGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personGroup = await _context.PersonGroups.FindAsync(id);
            _context.PersonGroups.Remove(personGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonGroupExists(int id)
        {
            return _context.PersonGroups.Any(e => e.GroupId == id);
        }
    }
}
