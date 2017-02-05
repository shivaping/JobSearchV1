using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSearch.DataAcccess.Models;
using JobSearch.BusinessLogic.Service;
using JobSearch.BusinessLogic.Repository.Interface.Repositories;

namespace JobSearch.BusinessLogic
{
    public interface IJobService : IService<Job>
    {
        int PostJob(Job job);
        IEnumerable<Job> GetJobs();

    }
    public class JobService : Service<Job>, IJobService
    {
        private readonly IRepositoryAsync<Job> _repository;

        public JobService(IRepositoryAsync<Job> repository) : base(repository)
        {
            _repository = repository;
        }

        public int PostJob(Job job)
        {
            // add business logic here
            return _repository.PostJob(job);
        }

        public IEnumerable<Job> GetJobs()
        {
            // add business logic here
            return _repository.GetJobs();
        }

        //public IEnumerable<CustomerOrder> GetCustomerOrder(string country)
        //{
        //    // add business logic here
        //    return _repository.GetCustomerOrder(country);
        //}

        //public override void Insert(Customer entity)
        //{
        //    // e.g. add business logic here before inserting
        //    base.Insert(entity);
        //}

        //public override void Delete(object id)
        //{
        //    // e.g. add business logic here before deleting
        //    base.Delete(id);
        //}
    }

    public static class JobRepository
    {
        public static int PostJob(this IRepository<Job> repository, Job job)
        {
            return 1;
        }
        public static IEnumerable<Job> GetJobs(this IRepository<Job> repository)
        {
            // add business logic here
            return repository.Queryable().ToList();
            //return _repository.CustomersByCompany(companyName);
        }
    }
}
