namespace JobSearch.Web.APIFacade.Client
{
    using System.Threading.Tasks;
    using JobSearch.WebAPIHelper.Model;
    using JobSearch.Web.APIFacade.Responses;

    public interface ILoginClient
    {
        Task<TokenResponse> Login(string email, string password);
        Task<RegisterResponse> Register(RegisterViewModel viewModel);
    }
}