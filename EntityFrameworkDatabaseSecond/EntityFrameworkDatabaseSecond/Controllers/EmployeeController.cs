using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkDatabaseSecond.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult OrderByName()
        {
            var employee = from e in db.Employees
                           orderby e.LastName ascending
                           select e;
            return View(employee);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Employee employee = db.Employees.Find(id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Employee employee = db.Employees.Find(id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Employee employee = db.Employees.Find(id);
            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Employee emp)
        {
            Employee employee = new Employee();
            if (ModelState.IsValid)
            {
                if(id == null)
                   return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                employee = db.Employees.Find(id);
                if (employee == null)
                    HttpNotFound();
                db.Employees.Remove(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

    }
}