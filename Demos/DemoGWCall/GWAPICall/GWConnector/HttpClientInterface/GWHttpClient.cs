using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Json;
using System.Text;

namespace GWAPICall.GWConnector.HttpClientInterface
{
    public class GWHttpClient : IHttpClient
    {
        public HttpClient Client { get; }
        private DefaultContractResolver contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy(),
        };
        private readonly ILogger logger;
        public GWHttpClient(HttpClient client, ILoggerFactory loggerFactory)
        {
            Client = client;
            logger = loggerFactory.CreateLogger<GWHttpClient>();

        }
        public HttpClient GetClient()
        {
            return Client;
        }

        public async Task<bool> Delete(string url)
        {
            return (await DeleteResponse(url)).IsSuccessStatusCode;
        }

        public async Task<T> Get<T>(string url)
        {
            HttpResponseMessage httpResponse = await GetResponse(url);
            return JsonConvert.DeserializeObject<T>(await httpResponse.Content.ReadAsStringAsync());
        }

        public async Task<T> PostJson<T, K>(string url, K content, string token)
        {
            //Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            var jsonString = JsonConvert.SerializeObject(content, new JsonSerializerSettings { ContractResolver = contractResolver });
            HttpResponseMessage response = await PostStringContent(url, jsonString,"application/json", token);
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }

        public async Task<T> PostJson<T, K>(string url, K content)
        {
            //var serializerSettings = new JsonSerializerSettings();
            //serializerSettings.ContractResolver = new
            //CamelCasePropertyNamesContractResolver();
            //var jsonString = JsonConvert.SerializeObject(content, serializerSettings);
            var jsonString = JsonConvert.SerializeObject(content, new JsonSerializerSettings { ContractResolver = contractResolver });
            //Client.DefaultRequestHeaders.Clear();
            //Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            HttpResponseMessage response = await PostStringContent(url,jsonString, "application/json");
            //var response = await Client.PostAsync(url, new StringContent(jsonString, Encoding.UTF8, "application/json"));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }

        public async Task<T> PutJson<T, K>(string url, K content)
        {
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new
            CamelCasePropertyNamesContractResolver();

            HttpResponseMessage response = await PutStringContent(url,
                JsonConvert.SerializeObject(content, serializerSettings),
                "application/json");

            //HttpResponseMessage response = await PutStringContent(url,
            //    JsonConvert.SerializeObject(content, new JsonSerializerSettings { ContractResolver = contractResolver }),
            //    "application/json");
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }

        public async Task<T> PostStringContent<T>(string url, string content, string contentType)
        {
            HttpResponseMessage response = await PostStringContent(url, content, contentType);
            if (!response.StatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                var responseDetail = await response.Content.ReadAsStringAsync();
                logger.LogError(response.ReasonPhrase + ": " + responseDetail);
            }
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }


        public async Task<HttpResponseMessage> PostStringContent(string url, string content, string contentType)
        {
            var result = await Client.PostAsync(url, new StringContent(content, Encoding.UTF8, contentType));
            return result;
        }

        public async Task<HttpResponseMessage> PostStringContent(string url, string content, string contentType, string token)
        {
             return await Client.PostAsync(url, new StringContent(content, Encoding.UTF8, contentType));
        }

        public async Task<HttpResponseMessage> GetResponse(string url)
        {
            return await Client.GetAsync(url);
        }

        public async Task<HttpResponseMessage> PutStringContent(string url, string content, string contentType)
        {
            return await Client.PutAsync(url, new StringContent(content, Encoding.UTF8, contentType));
        }

        public async Task<HttpResponseMessage> DeleteResponse(string url)
        {
            return await Client.DeleteAsync(url);
        }

        public async Task<T> PostFormDataAsync<T>(string url, List<KeyValuePair<string, string>> content)
        {
            HttpResponseMessage httpResponse = await Client.PostAsync(url, new FormUrlEncodedContent(content));
            var responseContent = await httpResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseContent);
        }

        public async Task<HttpResponseMessage> PostFormDataAsync(string url, List<KeyValuePair<string, string>> content)
        {
            var contentToPost = new FormUrlEncodedContent(content);
            HttpResponseMessage httpResponse = await Client.PostAsync(url, contentToPost);
            return httpResponse;
        }

    }
}
