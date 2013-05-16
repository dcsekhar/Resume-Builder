using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resume_Builder.Models;

namespace Resume_Builder.Controllers
{
    public class ResumeController : Controller
    {
        private ResumeDb db = new ResumeDb();

        //
        // GET: /Resume/

        public ActionResult Index()
        {
            return View(db.Resumes.ToList());
        }

        //
        // GET: /Resume/Details/5

        public ActionResult Details(int id = 0)
        {
            Resume resume = db.Resumes.Find(id);
            if (resume == null)
            {
                return HttpNotFound();
            }
            return View(resume);
        }

        //
        // GET: /Resume/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Resume/Create

        [HttpPost]
        public ActionResult Create(Resume resume)
        {
            if (ModelState.IsValid)
            {
                db.Resumes.Add(resume);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resume);
        }

        //
        // GET: /Resume/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Resume resume = db.Resumes.Find(id);
            if (resume == null)
            {
                return HttpNotFound();
            }
            return View(resume);
        }

        //
        // POST: /Resume/Edit/5

        [HttpPost]
        public ActionResult Edit(Resume resume)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resume).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resume);
        }

        //
        // GET: /Resume/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Resume resume = db.Resumes.Find(id);
            if (resume == null)
            {
                return HttpNotFound();
            }
            return View(resume);
        }

        //
        // POST: /Resume/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Resume resume = db.Resumes.Find(id);
            db.Resumes.Remove(resume);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}