using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_EF_Intro.Models;

namespace MVC_EF_Intro.Controllers
{
    public class FootballSchedulesController : Controller
    {
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        // GET: FootballSchedules
        public ActionResult Index()
        {
            return View(db.FootballSchedules.ToList());
        }

        // GET: FootballSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballSchedule footballSchedule = db.FootballSchedules.Find(id);
            if (footballSchedule == null)
            {
                return HttpNotFound();
            }
            return View(footballSchedule);
        }

        // GET: FootballSchedules/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FootballSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Season,Opponent,Date,IsHomeGame")] FootballSchedule footballSchedule)
        {
            if (ModelState.IsValid)
            {
                db.FootballSchedules.Add(footballSchedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(footballSchedule);
        }

        // GET: FootballSchedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballSchedule footballSchedule = db.FootballSchedules.Find(id);
            if (footballSchedule == null)
            {
                return HttpNotFound();
            }
            return View(footballSchedule);
        }

        // POST: FootballSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Season,Opponent,Date,IsHomeGame")] FootballSchedule footballSchedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(footballSchedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(footballSchedule);
        }

        // GET: FootballSchedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballSchedule footballSchedule = db.FootballSchedules.Find(id);
            if (footballSchedule == null)
            {
                return HttpNotFound();
            }
            return View(footballSchedule);
        }

        // POST: FootballSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FootballSchedule footballSchedule = db.FootballSchedules.Find(id);
            db.FootballSchedules.Remove(footballSchedule);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
