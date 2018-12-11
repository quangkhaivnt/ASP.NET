using NewExam_sem3.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewExam_sem3.Controllers
{
    public class NewExamController : Controller
    {
        NewExamDbContext db = new NewExamDbContext();
        // GET: NewExam
        public ActionResult Index()
        {
            return View(db.NewExams.Tolist());
        }

        // GET: NewExam/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewExam/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewExam/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NewExam/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewExam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NewExam/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewExam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
