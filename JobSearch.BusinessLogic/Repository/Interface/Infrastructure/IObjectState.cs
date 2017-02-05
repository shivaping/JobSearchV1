
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearch.BusinessLogic.Repository.Interface.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}