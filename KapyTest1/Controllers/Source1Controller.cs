using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KapyTest1.Models;

namespace KapyTest1.Controllers
{
    public class Source1Controller : Controller
    {
        private kapymvc1Entities db = new kapymvc1Entities();

        // GET: Source1
        public ActionResult Index()
        {
            return View(db.Source1.ToList());
        }

        // GET: Source1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Source1 source1 = db.Source1.Find(id);
            if (source1 == null)
            {
                return HttpNotFound();
            }
            return View(source1);
        }

        // GET: Source1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Source1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "sourceId,sourceName,sourceUrl")] Source1 source1)
        {
            if (ModelState.IsValid)
            {
                db.Source1.Add(source1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(source1);
        }

        // GET: Source1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Source1 source1 = db.Source1.Find(id);
            if (source1 == null)
            {
                return HttpNotFound();
            }
            return View(source1);
        }

        // POST: Source1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sourceId,sourceName,sourceUrl")] Source1 source1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(source1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(source1);
        }

        // GET: Source1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Source1 source1 = db.Source1.Find(id);
            if (source1 == null)
            {
                return HttpNotFound();
            }
            return View(source1);
        }

        // POST: Source1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Source1 source1 = db.Source1.Find(id);
            db.Source1.Remove(source1);
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
