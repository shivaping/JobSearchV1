namespace JobSearch.Web.APIFacade.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using JobSearch.WebAPIHelper.Client;
    using JobSearch.WebAPIHelper.Model;
    using JobSearch.WebAPIHelper.Response;
    using JobSearch.Web.APIFacade.Responses;
    using JobSearch.Web.APIFacade.ApiModels;
    public class LoginClient : ClientBase, ILoginClient
    {
        //private const string RegisterUri = "api/register";
        //private const string TokenUri = "api/token";
        private const string RegisterUri = "register";
        private const string TokenUri = "token";

        public LoginClient(IApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<TokenResponse> Login(string email, string password)
        {
            var response = await ApiClient.PostFormEncodedContent(TokenUri, "grant_type".AsPair("password"),
                "username".AsPair(email), "password".AsPair(password));
            var tokenResponse = await CreateJsonResponse<TokenResponse>(response);
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await DecodeContent<dynamic>(response);
                tokenResponse.ErrorState = new ErrorStateResponse
                {
                    ModelState = new Dictionary<string, string[]>
                    {
                        {errorContent["error"], new string[] {errorContent["error_description"]}}
                    }
                };
                return tokenResponse;
            }

            var tokenData = await DecodeContent<dynamic>(response);
            tokenResponse.Data = tokenData["access_token"];
            return tokenResponse;
        }

        public async Task<RegisterResponse> Register(RegisterViewModel viewModel)
        {
            var apiModel = new RegisterApiModel
            {
                ConfirmPassword = viewModel.ConfirmPassword,
                Email = viewModel.Email,
                Password = viewModel.Password
            };
            var response = await ApiClient.PostJsonEncodedContent(RegisterUri, apiModel);
            var registerResponse = await CreateJsonResponse<RegisterResponse>(response);
            return registerResponse;
        }
    }
}