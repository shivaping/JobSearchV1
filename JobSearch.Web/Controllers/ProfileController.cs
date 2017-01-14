using JobSearch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobSearch.Web.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View(new ProfileViewModel
                ()
            {
                Active = true,
                CurrentCtc = 10,
                CurrentLocation = "ban",
                CurrentRole = "engineer",
                Dob = DateTime.Now.AddYears(-36),
                EducationViewModel = new List<EducationViewModel>()
                   {
                       new EducationViewModel() { ID = 1, Institute = "RR", Qualification = "SS", Specialization= "DD", Year = 1980 },
                       new EducationViewModel() { ID = 2, Institute = "bb", Qualification = "gg", Specialization= "tt", Year = 1982 }
                   }, Email = "ss@ss.com",Experience = 10, Gender = "Male", Name="Shiva", ID=1, PhoneNumber="asdasdads", PreferredLocation= "Na",
 ProfileDescription= "adasdasdasdasdadasdsa asd asd ad asd asd ad asd asd adasd asd asdas", ProfileName="shivas",  Skill= "ASDASD,ASDASD, RTERT, EWRWER"            }
                );
        }

        // POST: Profile/Create
        [HttpPost]
        public ActionResult Create(ProfileViewModel profileModel)
        {
            //byte[] uploadedFile = new byte[collection.FileUpload.InputStream.Length];
            //collection.FileUpload.InputStream.Read(uploadedFile, 0, uploadedFile.Length);
            //         return File(
            //uploadedFile, System.Net.Mime.MediaTypeNames.Application.Octet, collection.FileUpload.FileName);
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Please correct all the validation errors");
                return View(profileModel);
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profile/Edit/5
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

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
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
