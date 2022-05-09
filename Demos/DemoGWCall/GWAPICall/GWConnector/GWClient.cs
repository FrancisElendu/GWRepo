using GWAPICall.GWConnector.Extensions;
using GWAPICall.GWConnector.HttpClientInterface;
using GWAPICall.GWConnector.Models;
using GWAPICall.GWConnector.Models.AccountModel.RequestModel;
using GWAPICall.GWConnector.Models.AccountModel.ResModel;
using GWAPICall.GWConnector.Models.GWQuote;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;
using static GWAPICall.GWConnector.Models.HO4Product;

namespace GWAPICall.GWConnector
{
    public class GWClient : IGWClient
    {
        private readonly ILogger<GWClient> _logger;
        private GWCredentials _credentials;
        private IHttpClient _client;
        private OAuthResponseModel tokenModel;
        public GWClient(
            ILogger<GWClient> logger,
            IOptions<GWCredentials> credentials,
            IHttpClient client
            )
        {
            _logger = logger;
            _credentials = credentials.Value;
            _client = client;
        }
        public async Task<Response> CreateAccount(Request requestModel)
        {
            var url = _credentials.AccountApiBaseUrl;
            await GenerateToken();
            _client.GetClient().WithBearer(tokenModel.AccessToken);

            return await _client.PostJson<Response, Request>(url, requestModel, tokenModel.AccessToken);
        }

        public async Task<QuoteResponse> SendGwRequest()
        {
            var response = await GwQuoteApiCall(_credentials.BaseUrl1);
            if (response == null) { return null; } else { return response; }
        }

        private async Task<QuoteResponse> GwQuoteApiCall(string baseUrl)
        {
            var response = await GwProductApiCall(_credentials.BaseUrl1);
            return await _client.Get<QuoteResponse>(baseUrl);
        }
        public async Task<Root> SendProductRequest()
        {
            var response = await GwProductApiCall(_credentials.BaseUrl3);
            if (response == null) {return null; } else { return response; }
        }

        private async Task<Root> GwProductApiCall(string baseUrl)
        {
            _client.GetClient().WithBasicAuth(_credentials.UserName, _credentials.Password);
            return await _client.Get<Root>(baseUrl);
        }

        private async Task GenerateToken()
        {
            List<KeyValuePair<string, string>> content = new List<KeyValuePair<string, string>>();
            content.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            content.Add(new KeyValuePair<string, string>("client_id", _credentials.ClientId));
            content.Add(new KeyValuePair<string, string>("client_secret", _credentials.ClientSecret));
            content.Add(new KeyValuePair<string, string>("scope", _credentials.Scope));
            //content.Add(new KeyValuePair<string, string>("username", _credentials.UserName));
            //content.Add(new KeyValuePair<string, string>("password", _credentials.Password));
            tokenModel = await _client.PostFormDataAsync<OAuthResponseModel>(_credentials.TokenGenUrl, content);
        }

    }
}
