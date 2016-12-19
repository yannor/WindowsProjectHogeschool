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
    public class EvenementenController : ApiController
    {
        private ProjectServiceContext db = new ProjectServiceContext();

        // GET: api/Evenementen
        public IQueryable<Evenement> GetEvenements()
        {
            return db.Evenements;
        }

        // GET: api/Evenementen/5
        [ResponseType(typeof(Evenement))]
        public IHttpActionResult GetEvenement(int id)
        {
            Evenement evenement = db.Evenements.Find(id);
            if (evenement == null)
            {
                return NotFound();
            }

            return Ok(evenement);
        }

        // PUT: api/Evenementen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEvenement(int id, Evenement evenement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != evenement.EvenementID)
            {
                return BadRequest();
            }

            db.Entry(evenement).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvenementExists(id))
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

        // POST: api/Evenementen
        [ResponseType(typeof(Evenement))]
        public IHttpActionResult PostEvenement(Evenement evenement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Evenements.Add(evenement);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = evenement.EvenementID }, evenement);
        }

        // DELETE: api/Evenementen/5
        [ResponseType(typeof(Evenement))]
        public IHttpActionResult DeleteEvenement(int id)
        {
            Evenement evenement = db.Evenements.Find(id);
            if (evenement == null)
            {
                return NotFound();
            }

            db.Evenements.Remove(evenement);
            db.SaveChanges();

            return Ok(evenement);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EvenementExists(int id)
        {
            return db.Evenements.Count(e => e.EvenementID == id) > 0;
        }
    }
}