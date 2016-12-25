using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobSearch.Web.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult CreateProfile()
        {
            return View();
        }

        public ActionResult PostJob()
        {
            return View();
        }

        public ActionResult ApplyJob()
        {
            return View();
        }
    }
}