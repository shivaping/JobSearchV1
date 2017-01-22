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


        ///<summary>
        ///Post the Job Details from JobViewModel Object
        ///</summary>
        ////// <param name="id">The ID of the data.</param>
        [Route("PostJob")]
        public HttpResponseMessage PostJob([FromBody]JobSearch.Model.JobViewModel JobDetails)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { UserDetails = portalRepository.GetUserDetail(User.Identity.GetUserId()) });

        }
    }
}
