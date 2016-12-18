using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSearch.DataAcccess.Models;
namespace JobSearch.BusinessLogic.Repository
{
    public interface IJobPortalRepository
    {
        UserDetail GetUserDetail(string userID);
        bool SaveUserDetails(UserDetail user);
    }
}
