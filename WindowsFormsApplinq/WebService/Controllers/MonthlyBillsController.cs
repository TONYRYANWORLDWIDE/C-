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
using WebService.Models;

namespace WebService.Controllers
{
    public class MonthlyBillsController : ApiController
    {
        private TRBillsEntities db = new TRBillsEntities("AzureWebApp#1");

        // GET: api/MonthlyBills
        public IQueryable<MonthlyBill> GetMonthlyBills()
        {
            return db.MonthlyBills;
        }

        // GET: api/MonthlyBills/5
        [ResponseType(typeof(MonthlyBill))]
        public IHttpActionResult GetMonthlyBill(string id)
        {
            MonthlyBill monthlyBill = db.MonthlyBills.Find(id);
            if (monthlyBill == null)
            {
                return NotFound();
            }
            return Ok(monthlyBill);
        }
        // PUT: api/MonthlyBills/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMonthlyBill(string id, MonthlyBill monthlyBill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != monthlyBill.BILL)
            {
                return BadRequest();
            }

            db.Entry(monthlyBill).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonthlyBillExists(id))
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

        // POST: api/MonthlyBills
        [ResponseType(typeof(MonthlyBill))]
        public IHttpActionResult PostMonthlyBill(MonthlyBill monthlyBill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MonthlyBills.Add(monthlyBill);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (MonthlyBillExists(monthlyBill.BILL))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = monthlyBill.BILL }, monthlyBill);
        }

        // DELETE: api/MonthlyBills/5
        [ResponseType(typeof(MonthlyBill))]
        public IHttpActionResult DeleteMonthlyBill(string id)
        {
            MonthlyBill monthlyBill = db.MonthlyBills.Find(id);
            if (monthlyBill == null)
            {
                return NotFound();
            }

            db.MonthlyBills.Remove(monthlyBill);
            db.SaveChanges();

            return Ok(monthlyBill);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MonthlyBillExists(string id)
        {
            return db.MonthlyBills.Count(e => e.BILL == id) > 0;
        }
    }
}