using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            // Create a new Admin model instance
            var model = new Admin();

            // Retrieve a list of Insurees from the database
            var insurees = db.Insurees.ToList();

            // Iterate through each Insuree in the list and add to Admin model
            foreach (var person in insurees)
            {
                var quoteVm = new QuoteVM();

                quoteVm.FirstName = person.FirstName;
                quoteVm.LastName = person.LastName;
                quoteVm.EmailAddress = person.EmailAddress;
                quoteVm.Quote = person.Quote;

                model.InsureeList.Add(quoteVm);
            }

            // Return a view with the populated Admin model
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public decimal CalculateQuote (Insuree insuree)
        {
            decimal baseQuote = 50.00m;

            if (insuree.DateOfBirth.Year >= DateTime.Now.Year - 18)
            {
                baseQuote += 100.00m;
            }
            else if (insuree.DateOfBirth.Year >= DateTime.Now.Year - 25)
            {
                baseQuote += 50.00m;
            }
            else
            {
                baseQuote += 25.00m;
            }

            if (insuree.CarYear < 2000)
            {
                baseQuote += 25.00m;
            }
            else if (insuree.CarYear > 2015)
            {
                baseQuote += 25.00m;
            }

            if (insuree.CarMake == "Porsche")
            {
                baseQuote += 25.00m;
                if (insuree.CarModel == "911 Carrera")
                {
                    baseQuote += 25.00m;
                }
            }

            baseQuote += insuree.SpeedingTickets * 10.00m;

            if (insuree.DUI)
            {
                baseQuote += baseQuote * .25m;
            }

            if (insuree.CoverageType)
            {
                baseQuote += baseQuote * .50m;
            }

            return baseQuote;
        }
    }
}
