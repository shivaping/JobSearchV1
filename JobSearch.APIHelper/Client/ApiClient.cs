﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using JobSearch.Model;
using System.Web.Script.Serialization;
namespace JobSearch.APIHelper.Client
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient httpClient;
        private readonly ITokenContainer tokenContainer;

        public ApiClient(HttpClient httpClient, ITokenContainer tokenContainer)
        {
            this.httpClient = httpClient;
            this.tokenContainer = tokenContainer;
        }

        public async Task<HttpResponseMessage> GetFormEncodedContent(string requestUri, params KeyValuePair<string, string>[] values)
        {
            AddToken();
            using (var content = new FormUrlEncodedContent(values))
            {
                var query = await content.ReadAsStringAsync();
                var requestUriWithQuery = string.Concat(requestUri, "?", query);
                var response = await httpClient.GetAsync(requestUriWithQuery);
                return response;
            }
        }

        public async Task<HttpResponseMessage> PostFormEncodedContent(string requestUri, params KeyValuePair<string, string>[] values)
        {
                 
            using (var content = new FormUrlEncodedContent(values))
            {
                var response = await httpClient.PostAsync(requestUri, content);
                return response;
            }
        }

        public async Task<HttpResponseMessage> PostJsonEncodedContent<T>(string requestUri, T content) where T : ApiModel
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            AddToken();
            var response = await httpClient.PostAsync(requestUri, new StringContent(new JavaScriptSerializer().Serialize(content), Encoding.UTF8, "application/json"));
            return response;
        }

        private void AddToken()
        {
            if (tokenContainer.ApiToken != null)
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenContainer.ApiToken.ToString());
            }
        }
    }
}
