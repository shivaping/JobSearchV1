using JobSearch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using System.Text;

namespace JobSearch.Web.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View(GetProfiles());
        }

        // GET: Profile/Details/5
        public ActionResult Details(int id)
        {
            return View(GetProfiles().Find(p=>p.ID == id));
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            return View();
        }
        public List<ProfileViewModel> GetProfiles()
        {
            List<ProfileViewModel> returnData = new List<ProfileViewModel>();
            returnData.Add(
            new ProfileViewModel
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
                   },
                Email = "ss@ss.com",
                Experience = 10,
                Gender = GenderType.Female,
                ResumeFileName = "Uploaded Document.PDF",
                ID = 1,
                PhoneNumber = "9845280207",
                PreferredLocation = "Na",
                ProfileDescription = "adasdasdasdasdadasdsa asd asd ad asd asd ad asd asd adasd asd asdas",
                ProfileName = "shivas",
                Skill = "ASDASD,ASDASD, RTERT, EWRWER"
            });
            returnData.Add(
           new ProfileViewModel
               ()
           {
               Active = true,
               CurrentCtc = 10,
               CurrentLocation = "ban",
               CurrentRole = "Architect",
               Dob = DateTime.Now.AddYears(-36),
               EducationViewModel = new List<EducationViewModel>()
                  {
                       new EducationViewModel() { ID = 1, Institute = "RR", Qualification = "SS", Specialization= "DD", Year = 1980 },
                       new EducationViewModel() { ID = 2, Institute = "bb", Qualification = "gg", Specialization= "tt", Year = 1982 }
                  },
               Email = "ss@ss.com",
               Experience = 10,
               Gender = GenderType.Female,
               ResumeFileName = "Uploaded Document1.PDF",
               ID = 2,
               PhoneNumber = "+919845280208",
               PreferredLocation = "ABCED",
               ProfileDescription = "glkktetlkhert wlrhowithndfxmbhjadga aslkdhjasl fdalkt.nwelkrew ",
               ProfileName = "shivas 2",
               Skill = "ASDASD,ASDASD, RTERT, EWRWER, asadasdsasd"
           });
            return returnData;
        }
        // POST: Profile/Create
        [HttpPost]
        public ActionResult Create(ProfileViewModel profileModel)
        {
            byte[] uploadedFile = new byte[profileModel.FileUpload.InputStream.Length];
            profileModel.FileUpload.InputStream.Read(uploadedFile, 0, uploadedFile.Length);
            profileModel.ResumeFileName = profileModel.FileUpload.FileName;
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var ErrorList = ModelState.Values.Where(p => p.Errors.Count() > 0).ToList();
                StringBuilder sb = new StringBuilder();
                ErrorList.ForEach(p => { p.Errors.ToList().ForEach(q => { sb.AppendLine(q.ErrorMessage); }); });
                ModelState.AddModelError("", sb.ToString());
                return View(profileModel);
            }
  //          return File(
  //uploadedFile, System.Net.Mime.MediaTypeNames.Application.Octet, profileModel.FileUpload.FileName);
        }

        // GET: Profile/Edit/5
        public ActionResult Update(int id)
        {
            ProfileViewModel profileViewModel = GetProfiles().Find(p => p.ID == id);
            return View(profileViewModel);
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
