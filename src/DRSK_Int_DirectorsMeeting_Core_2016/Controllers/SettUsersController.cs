using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Concretes;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Controllers
{
    public class SettUsersController : Controller
    {
        private FosAgroContext _context;

        public SettUsersController(FosAgroContext context)
        {
            _context = context;    
        }

        // GET: SettUsers
        public async Task<IActionResult> Index()
        {
            var fosAgroContext = _context.SettUser.Include(s => s.Setting).Include(s => s.User);
            return View(await fosAgroContext.ToListAsync());
        }

        // GET: SettUsers/Details/5
        public async Task<IActionResult> Details(long UserId = 0, long SettingId = 0)
        {
            SettUser settUser = await _context.SettUser.SingleAsync(m => m.UserId == UserId && m.SettingId == SettingId);
            if (settUser == null)
            {
                return HttpNotFound();
            }

            return View(settUser);
        }

        // GET: SettUsers/Create
        public IActionResult Create()
        {
            ViewData["SettingId"] = new SelectList(_context.DictSettUser, "Id", "Setting");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "User");
            return View();
        }

        // POST: SettUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SettUser settUser)
        {
            if (ModelState.IsValid)
            {
                _context.SettUser.Add(settUser);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["SettingId"] = new SelectList(_context.DictSettUser, "Id", "Setting", settUser.SettingId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "User", settUser.UserId);
            return View(settUser);
        }

        // GET: SettUsers/Edit/5
        public async Task<IActionResult> Edit(long UserId = 0, long SettingId = 0)
        {
            SettUser settUser = await _context.SettUser.SingleAsync(m => m.UserId == UserId && m.SettingId == SettingId);
            if (settUser == null)
            {
                return HttpNotFound();
            }
            ViewData["SettingId"] = new SelectList(_context.DictSettUser, "Id", "Setting", settUser.SettingId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "User", settUser.UserId);
            return View(settUser);
        }

        // POST: SettUsers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SettUser settUser)
        {
            if (ModelState.IsValid)
            {
                _context.Update(settUser);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["SettingId"] = new SelectList(_context.DictSettUser, "Id", "Setting", settUser.SettingId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "User", settUser.UserId);
            return View(settUser);
        }

        // GET: SettUsers/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(long UserId = 0, long SettingId = 0)
        {
            SettUser settUser = await _context.SettUser.SingleAsync(m => m.UserId == UserId && m.SettingId == SettingId);
            if (settUser == null)
            {
                return HttpNotFound();
            }

            return View(settUser);
        }

        // POST: SettUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long UserId = 0, long SettingId = 0)
        {
            SettUser settUser = await _context.SettUser.SingleAsync(m => m.UserId == UserId && m.SettingId == SettingId);
            if (settUser == null)
            {
                return HttpNotFound();
            }
            _context.SettUser.Remove(settUser);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
