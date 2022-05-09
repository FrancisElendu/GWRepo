namespace GWAPICall.GWConnector.HttpClientInterface
{
    public interface IHttpClient
    {
        Task<T> PostJson<T, K>(string url, K content, string token);
        Task<T> PostJson<T, K>(string url, K content);
        Task<T> Get<T>(string url);
        Task<T> PutJson<T, K>(string url, K content);
        Task<bool> Delete(string url);
        Task<T> PostStringContent<T>(string url, string content, string contentType);
        Task<T> PostFormDataAsync<T>(string url, List<KeyValuePair<string, string>> content);
        HttpClient GetClient();
        Task<HttpResponseMessage> PostStringContent(string url, string content, string contentType, string token);
        Task<HttpResponseMessage> GetResponse(string url);
        Task<HttpResponseMessage> PutStringContent(string url, string content, string contentType);
        Task<HttpResponseMessage> DeleteResponse(string url);
        Task<HttpResponseMessage> PostFormDataAsync(string url, List<KeyValuePair<string, string>> content);

    }
}
