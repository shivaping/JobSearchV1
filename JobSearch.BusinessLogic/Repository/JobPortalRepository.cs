using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSearch.DataAcccess.Models;

namespace JobSearch.BusinessLogic.Repository
{/*
    public class JobPortalRepository : IJobPortalRepository
    {
        private JobPortalContext context;
        public JobPortalRepository(JobPortalContext context)
        {
            this.context = context;
            this.context.Configuration.ProxyCreationEnabled = false;
        }

        public UserDetail GetUserDetail(string userID)
        {
            UserDetail returnValue = context.UserDetails.Find(userID);
            context.Entry(returnValue).Collection(p => p.UserProfiles).Load();
            //context.UserDetails.Include("UserDetail.UserResumes");
            //context.Entry(UserDetail).Reference(p=>p.)
          
            return returnValue;
        }

        public bool SaveUserDetails(UserDetail user)
        {
            bool returnValue = false;
            using (System.Data.Entity.DbContextTransaction dbTran = context.Database.BeginTransaction())
            {
                try
                {
                    context.UserDetails.Add(user);
                    context.SaveChanges();

                    dbTran.Commit();
                }
                catch (Exception)
                {
                    returnValue = false;
                    dbTran.Rollback();
                    throw;
                }
            }
            return returnValue;
        }
    }
    */
    //public interface IUnitOfWork
    //{
    //    IJobPortalRepository IRepository { get; }
    //    void Save();
    //}

    //public class UnitOfWork : IDisposable, IUnitOfWork
    //{
    //    readonly JobPortalContext _context = new JobPortalContext();
    //    IJobPortalRepository _IJobPortalRepository;
        
    //    public IJobPortalRepository IRepository
    //    {
    //        get { return _IJobPortalRepository ?? (_IJobPortalRepository = new JobPortalRepository(_context)); }
    //    }

    //    public void Dispose()
    //    {
    //        if (_context != null)
    //        {
    //            _context.Dispose();
    //        }
    //    }

    //    void IUnitOfWork.Save()
    //    {
    //        _context.SaveChanges();
    //    }

       
    //}
}
