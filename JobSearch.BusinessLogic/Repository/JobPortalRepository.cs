using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSearch.DataAcccess.Models;

namespace JobSearch.BusinessLogic.Repository
{
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
            UserDetail returnValue = null;
            returnValue = context.UserDetails.Where(p => p.UserID == userID).FirstOrDefault();
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
}
