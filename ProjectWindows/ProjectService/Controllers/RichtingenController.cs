using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectService.Models;

namespace ProjectService.Controllers
{
    public class RichtingenController : ApiController
    {
        private ProjectServiceContext db = new ProjectServiceContext();

        // GET: api/Richtingen
        public IQueryable<Richting> GetRichtings()
        {
            return db.Richtings;
        }

        // GET: api/Richtingen/5
        [ResponseType(typeof(Richting))]
        public IHttpActionResult GetRichting(int id)
        {
            Richting richting = db.Richtings.Find(id);
            if (richting == null)
            {
                return NotFound();
            }

            return Ok(richting);
        }

        // PUT: api/Richtingen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRichting(int id, Richting richting)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != richting.RichtingID)
            {
                return BadRequest();
            }

            db.Entry(richting).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RichtingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Richtingen
        [ResponseType(typeof(Richting))]
        public IHttpActionResult PostRichting(Richting richting)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Richtings.Add(richting);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = richting.RichtingID }, richting);
        }

        // DELETE: api/Richtingen/5
        [ResponseType(typeof(Richting))]
        public IHttpActionResult DeleteRichting(int id)
        {
            Richting richting = db.Richtings.Find(id);
            if (richting == null)
            {
                return NotFound();
            }

            db.Richtings.Remove(richting);
            db.SaveChanges();

            return Ok(richting);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RichtingExists(int id)
        {
            return db.Richtings.Count(e => e.RichtingID == id) > 0;
        }
    }
}