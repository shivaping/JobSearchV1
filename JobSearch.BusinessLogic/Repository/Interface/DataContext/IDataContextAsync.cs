using System.Threading;
using System.Threading.Tasks;

namespace JobSearch.BusinessLogic.Repository.Interface.DataContext
{
    public interface IDataContextAsync : IDataContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }
}