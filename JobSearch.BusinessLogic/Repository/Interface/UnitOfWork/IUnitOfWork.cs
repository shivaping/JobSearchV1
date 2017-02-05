using System;
using System.Data;
using JobSearch.BusinessLogic.Repository.Interface.Infrastructure;
using JobSearch.BusinessLogic.Repository.Interface.Repositories;

namespace JobSearch.BusinessLogic.Repository.Interface.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;//, IObjectState;
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        bool Commit();
        void Rollback();
    }
}