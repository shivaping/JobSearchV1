using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobSearch.BusinessLogic.Repository;
using Microsoft.AspNet.Identity;

namespace JobSearch.WebAPI.Controllers
{

    [RoutePrefix("api/jobsearch")]
    public class JobSearchController : ApiController
    {
        private readonly IJobPortalRepository portalRepository;
        private readonly IUnitOfWork portalUnitOfWork;
        public JobSearchController()
        {
            
        }
        public JobSearchController(IJobPortalRepository _IJobPortalRepository, IUnitOfWork _IUnitOfWork)
        {
            portalRepository = _IJobPortalRepository;
            this.portalUnitOfWork = _IUnitOfWork;
        }
        [Authorize]
        [Route("UserDetails")]
        public HttpResponseMessage GetUserDetail()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { UserDetails = portalRepository.GetUserDetail(User.Identity.GetUserId()) });
            
        }
        //// Get all orders
        //[Route("jobs")]
        //public List<Job> GetJobs()
        //{
        //    List<Job> returnValue = ctx.Jobs.ToList();
        //    return returnValue;
        //}
        //// Get Orders based on Criteria
        //[Route("jobs/{keyword}")]
        //public List<Job> GetJobsByFilter(string keyword)
        //{
        //    List<Job> returnValue = ctx.Jobs.Where(p => p.client.Contains(keyword) ||
        //     p.generalskills.Contains(keyword) || p.location.Contains(keyword)).ToList();
        //    return returnValue;
        //}
    }
}
