using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Concretes;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Controllers
{
    [Produces("application/json")]
    [Route("api/UsersApi")]
    public class UsersApiController : Controller
    {
        private IRepository<Users> _context;

        public UsersApiController(IRepository<Users> context)
        {
            _context = context;
        }

        // GET: api/UsersApi
        [HttpGet]
        public IEnumerable<Users> GetUsers()
        {
            return _context.List();
        }

        // GET: api/UsersApi/5
        [HttpGet("{id}", Name = "GetUsers")]
        public async Task<IActionResult> GetUser([FromRoute] long id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return HttpBadRequest(ModelState);
            //}

            Users users = await _context.GetAsync(m => m.Id == id);

            if (users == null)
            {
                return HttpNotFound();
            }

            return Ok(users);
        }

        // PUT: api/UsersApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser([FromRoute] long id, [FromBody] Users users)
        {
            //if (!ModelState.IsValid)
            //{
            //    return HttpBadRequest(ModelState);
            //}

            if (id != users.Id)
            {
                return HttpBadRequest();
            }

            _context.Entry(users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
                {
                    return HttpNotFound();
                }
                else
                {
                    throw;
                }
            }

            return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
        }

        // POST: api/UsersApi
        [HttpPost]
        public async Task<IActionResult> PostUsers([FromBody] Users users)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }


            try
            {
                await _context.AddAsync(users);
            }
            catch (DbUpdateException)
            {
                if (UsersExists(users.Id))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetUsers", new { id = users.Id }, users);
        }

        // DELETE: api/UsersApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsers([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Users users = await _context.GetAsync(m => m.Id == id);
            if (users == null)
            {
                return HttpNotFound();
            }

            await _context.DeleteAsync(users);

            return Ok(users);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersExists(long id)
        {
            return _context.Count(e => e.Id == id) > 0;
        }
    }
}