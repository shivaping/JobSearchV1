using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobSearch.Model;
namespace JobSearch.Web.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult Index()
        {
            return View(new List<JobViewModel>());
        }

        // GET: Job/Details/5
        public ActionResult Details(int id)
        {
            return View(new JobViewModel());
        }

        // GET: Job/Create
        public ActionResult PostJob()
        {
            return View(new JobViewModel());
        }

        // POST: Job/Create
        [HttpPost]
        public ActionResult PostJob(JobViewModel jobViewModel)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(jobViewModel);
            }
        }

        // GET: Job/Edit/5
        public ActionResult EditJob(int id)
        {
            return View(new JobViewModel());
        }

        // POST: Job/Edit/5
        [HttpPost]
        public ActionResult EditJob(int id, JobViewModel jobViewModel)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(jobViewModel);
            }
        }

        // GET: Job/Delete/5
        public ActionResult DeleteJob(int id)
        {
            return View();
        }

        // POST: Job/Delete/5
        [HttpPost]
        public ActionResult DeleteJob(int id, FormCollection collection)
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
