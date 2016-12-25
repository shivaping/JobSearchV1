using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using JobSearch.Model;
namespace JobSearch.Web.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult CreateProfile()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProfile(object obj)
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