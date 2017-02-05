using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobSearch.BusinessLogic.Repository;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using JobSearch.DataAcccess.Models;
using JobSearch.BusinessLogic;


namespace JobSearch.WebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/jobsearch")]
    public class JobSearchController : ApiController
    {
        UnitOfWork unitofwork = new UnitOfWork();
        /// <summary>
        /// 
        /// </summary>
        public JobSearchController()
        {
           
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [Route("UserDetails")]
        public HttpResponseMessage GetUserDetail()
        {
            //return Request.CreateResponse(HttpStatusCode.OK, new { UserDetails = portalRepository.GetUserDetail(User.Identity.GetUserId()) });
            return Request.CreateResponse(HttpStatusCode.OK );
        }


        ///<summary>
        ///Post the Job Details from JobViewModel Object
        ///</summary>
        ////// <param name="id">The ID of the data.</param>
        [Route("PostJob")]
        public HttpResponseMessage PostJob([FromBody]JobSearch.Model.JobViewModel JobDetails)
        {
            
            //return Request.CreateResponse(HttpStatusCode.OK, new { UserDetails = portalRepository.GetUserDetail(User.Identity.GetUserId()) });
            return Request.CreateResponse(HttpStatusCode.OK, Newtonsoft.Json.JsonConvert.SerializeObject(JobDetails));
        }
        /// <summary>
        /// Get the Job details
        /// </summary>
        /// <returns></returns>
        [Route("GetJobs")]
        public HttpResponseMessage GetJobs()
        {
            //List<JobSearch.Model.JobViewModel> jobs = new List<Model.JobViewModel>();
            //jobs.Add(new Model.JobViewModel() { AboutCompany = "About Client1", Client = "Client1", CreatedBy = Guid.NewGuid().ToString(), GeneralSkills = "GeneralSkills1", JobDescription = "JobDescription1", MaxExperience = 10, MinExperience = 1, Positions = 2, ReferralAmount = 10, TechnicalSkills = "Technicalskills", Technology = ".net", Location = "Bangalore", JobType = Model.JobType.Contract, Title = "Title" });
            //jobs.Add(new Model.JobViewModel() { AboutCompany = "About Client1", Client = "Client1", CreatedBy = Guid.NewGuid().ToString(), GeneralSkills = "GeneralSkills1", JobDescription = "JobDescription1", MaxExperience = 10, MinExperience = 1, Positions = 2, ReferralAmount = 10, TechnicalSkills = "Technicalskills", Technology = ".net", Location = "Bangalore", JobType = Model.JobType.Contract, Title = "Title" });
            var result = unitofwork.StudentRepository.GetAll();
            var responseString = Newtonsoft.Json.JsonConvert.SerializeObject(result, Formatting.Indented,
    new JsonSerializerSettings()
    {
        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    });
            return Request.CreateResponse(HttpStatusCode.OK, responseString);
        }

    }
}
