using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using net_pers_fin.Data;
using net_pers_fin.Models;

namespace net_pers_fin.Controllers
{
    public class UsersController : Controller
    {
        private readonly net_pers_fin_context _context;

        public UsersController(net_pers_fin_context context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var User = await _context.User
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (User == null)
            {
                return NotFound();
            }

            return View(User);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,First,Last,Active,Verified,Createdon,Lastlogin")] User User)
        {
            if (ModelState.IsValid)
            {
                _context.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(User);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var User = await _context.User.FindAsync(Id);
            if (User == null)
            {
                return NotFound();
            }
            return View(User);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,First,Last,Active,Verified,Createdon,Lastlogin")] User User)
        {
            if (Id != User.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(User);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(User.Id))
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
            return View(User);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var User = await _context.User
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (User == null)
            {
                return NotFound();
            }

            return View(User);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var User = await _context.User.FindAsync(Id);
            if (User != null)
            {
                _context.User.Remove(User);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int Id)
        {
            return _context.User.Any(e => e.Id == Id);
        }
    }
}
