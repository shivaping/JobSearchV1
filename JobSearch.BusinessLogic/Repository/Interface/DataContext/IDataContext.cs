using System;
using JobSearch.BusinessLogic.Repository.Interface.Infrastructure;

namespace JobSearch.BusinessLogic.Repository.Interface.DataContext
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();
        void SyncObjectState<TEntity>(TEntity entity) where TEntity : class;//, IObjectState;
        void SyncObjectsStatePostCommit();
    }
}