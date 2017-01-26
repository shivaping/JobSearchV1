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
            return View();
        }

       
        // GET: Job/Create
        public ActionResult PostJob()
        {
            return View();
        }
       
    }
}
