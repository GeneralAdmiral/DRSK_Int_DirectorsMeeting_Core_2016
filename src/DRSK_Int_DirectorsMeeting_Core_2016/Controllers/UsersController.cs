using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Concretes;
using System.Threading.Tasks;
using System;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private IRepository<Users> _context;

        public UsersController(IRepository<Users> context)
        {
            this._context = context;
        }

        // GET: api/Users
        [HttpGet]
        public void GetUsers()
        {
            try
            {
                var user = new Users() {
                    AdName = "AdNameForTest",
                    Name = "NameForTest",
                    Sid = "SidForTest",
                    UpdateDate = DateTime.Now,
                    RegisterDate = DateTime.Now };

                var result = this._context.Add(user);
                this.Redirect("/MeetingsQuestions/Index");
            }
            catch (Exception ex)
            {

            }

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }

            base.Dispose(disposing);
        }

        private bool UsersExists(int id)
        {
            return _context.Count(e => e.Id == id) > 0;
        }
    }
}