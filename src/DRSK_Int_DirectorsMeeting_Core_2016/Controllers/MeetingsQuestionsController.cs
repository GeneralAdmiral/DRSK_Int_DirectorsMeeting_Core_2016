using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Concretes;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Controllers
{
    public class MeetingsQuestionsController : Controller
    {
        //private FosAgroContext _context;

        //public MeetingsQuestionsController(FosAgroContext context)
        //{
        //    _context = context;    
        //}

        //// GET: MeetingsQuestions
        //public async Task<IActionResult> Index()
        //{
        //    var fosAgroContext = _context.MeetingsQuestions
        //        .Include(m => m.DirectorsGroup)
        //        .Include(m => m.Meeting)
        //        .Include(m => m.ParentQuestion)
        //        .Include(m => m.UpdUser);
        //    return View(await fosAgroContext.ToListAsync());
        //}

        // GET: MeetingsQuestions/Details/5

        private readonly IRepository<MeetingsQuestions> _context;
        private readonly IRepository<Users> _users;

        public MeetingsQuestionsController(IRepository<MeetingsQuestions> context,
                                           IRepository<Users> users)
        {
            this._context = context;
            this._users = users;
        }

        // GET: MeetingsQuestions
        public async Task<IActionResult> Index(int result = -1)
        {
            if (result == -1)
            {
                var fosAgroContext = await _context.ListAsync();
                return View(fosAgroContext.ToList());
            }
            else
            {
                return View();
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> Details(long id = -1)
        {
            if (id == -1)
            {
                return HttpNotFound();
            }

            MeetingsQuestions meetingsQuestions = await _context.GetAsync(id);
            if (meetingsQuestions == null)
            {
                return HttpNotFound();
            }

            return View(meetingsQuestions);
        }

        // GET: MeetingsQuestions/Create
        public IActionResult Create()
        {
            //ViewData["DirectorsGroupId"] = new SelectList(_context.DictDirectorsGroups, "Id", "DirectorsGroup");
            //ViewData["MeetingId"] = new SelectList(_context.Meetings, "Id", "Meeting");
            //ViewData["ParentQuestionId"] = new SelectList(_context.MeetingsQuestions, "Id", "ParentQuestion");
            return View();
        }

        // POST: MeetingsQuestions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult  Create(MeetingsQuestions meetingsQuestions)
        {
            if (ModelState.IsValid)
            {
                var user = this._users.Get(3);
                meetingsQuestions.UpdUserId = user.Id;
                this._context.Add(meetingsQuestions);
                return RedirectToAction("Index");
            }
            //ViewData["DirectorsGroupId"] = new SelectList(_context.DictDirectorsGroups, "Id", "DirectorsGroup", meetingsQuestions.DirectorsGroupId);
            //ViewData["MeetingId"] = new SelectList(_context.Meetings, "Id", "Meeting", meetingsQuestions.MeetingId);
            //ViewData["ParentQuestionId"] = new SelectList(_context.MeetingsQuestions, "Id", "ParentQuestion", meetingsQuestions.ParentQuestionId);
            //ViewData["UpdUserId"] = new SelectList(this._users, "Id", "UpdUser", meetingsQuestions.UpdUserId);
            return View(meetingsQuestions);
        }

        // GET: MeetingsQuestions/Edit/5
        public IActionResult Edit(long id = 0)
        {
            if (id < 0)
            {
                return HttpNotFound();
            }

            MeetingsQuestions meetingsQuestions = this._context.Get(id);
            if (meetingsQuestions == null)
            {
                return HttpNotFound();
            }
            //ViewData["DirectorsGroupId"] = new SelectList(_context.DictDirectorsGroups, "Id", "DirectorsGroup", meetingsQuestions.DirectorsGroupId);
            //ViewData["MeetingId"] = new SelectList(_context.Meetings, "Id", "Meeting", meetingsQuestions.MeetingId);
            //ViewData["ParentQuestionId"] = new SelectList(_context.MeetingsQuestions, "Id", "ParentQuestion", meetingsQuestions.ParentQuestionId);
            //ViewData["UpdUserId"] = new SelectList(_context.Users, "Id", "UpdUser", meetingsQuestions.UpdUserId);
            return View(meetingsQuestions);
        }

        // POST: MeetingsQuestions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MeetingsQuestions meetingsQuestions)
        {
            if (ModelState.IsValid)
            {
                //_context.Update(meetingsQuestions);
                //await _context.SaveChangesAsync();

                this._context.Update(meetingsQuestions);
                return RedirectToAction("Index");
            }
            //ViewData["DirectorsGroupId"] = new SelectList(_context.DictDirectorsGroups, "Id", "DirectorsGroup", meetingsQuestions.DirectorsGroupId);
            //ViewData["MeetingId"] = new SelectList(_context.Meetings, "Id", "Meeting", meetingsQuestions.MeetingId);
            //ViewData["ParentQuestionId"] = new SelectList(_context.MeetingsQuestions, "Id", "ParentQuestion", meetingsQuestions.ParentQuestionId);
            //ViewData["UpdUserId"] = new SelectList(_context.Users, "Id", "UpdUser", meetingsQuestions.UpdUserId);
            return View(meetingsQuestions);
        }

        // GET: MeetingsQuestions/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(long id = 0)
        {
            if (id >= 0)
            {
                return HttpNotFound();
            }

            MeetingsQuestions meetingsQuestions = await this._context.GetAsync(id);
            if (meetingsQuestions == null)
            {
                return HttpNotFound();
            }

            return View(meetingsQuestions);
        }

        // POST: MeetingsQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id = 0)
        {
            //MeetingsQuestions meetingsQuestions = await _context.MeetingsQuestions.SingleAsync(m => m.Id == id);
            //_context.MeetingsQuestions.Remove(meetingsQuestions);
            //await _context.SaveChangesAsync();

            MeetingsQuestions meetingsQuestions = await this._context.GetAsync(id);
            var result = await this._context.DeleteAsync(meetingsQuestions);
            return RedirectToAction("Index", result);
        }
    }
}
