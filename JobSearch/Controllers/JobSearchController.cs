using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JobSearch.WebAPIHelper.Models;
namespace JobSearch.Controllers
{
    [RoutePrefix("api/jobsearch")]
    public class JobSearchController : ApiController
    {
        JobPortalContext ctx;
        public JobSearchController()
        {
            ctx = new JobPortalContext();
        }

        // Get all orders
        [Route("jobs")]
        public List<Job> GetJobs()
        {
            List<Job> returnValue = ctx.Jobs.ToList();
            return returnValue;
        }
        // Get Orders based on Criteria
        [Route("jobs/{keyword}")]
        public List<Job> GetJobsByFilter(string keyword)
        {
            List<Job> returnValue = ctx.Jobs.Where(p=>p.client.Contains(keyword) ||
             p.generalskills.Contains(keyword) || p.location.Contains(keyword)).ToList();
            return returnValue;
        }
    }
}
