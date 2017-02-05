using System.Threading;
using System.Threading.Tasks;
using JobSearch.BusinessLogic.Repository.Interface.Infrastructure;
using JobSearch.BusinessLogic.Repository.Interface.Repositories;

namespace JobSearch.BusinessLogic.Repository.Interface.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class;//, IObjectState;
    }
}