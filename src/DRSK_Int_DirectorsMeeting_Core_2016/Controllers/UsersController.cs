using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Concretes;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Controllers
{
    public class UsersController : Controller
    {
        private FosAgroContext _context;

        public UsersController(FosAgroContext context)
        {
            _context = context;    
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            string sid = null;
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Users users = await _context.Users.SingleAsync(m => m.Id == id);
            if (users == null)
            {
                return HttpNotFound();
            }

            return View(users);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(users);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Users users = await _context.Users.SingleAsync(m => m.Id == id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Update(users);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(users);
        }

        // GET: Users/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Users users = await _context.Users.SingleAsync(m => m.Id == id);
            if (users == null)
            {
                return HttpNotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            Users users = await _context.Users.SingleAsync(m => m.Id == id);
            _context.Users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
