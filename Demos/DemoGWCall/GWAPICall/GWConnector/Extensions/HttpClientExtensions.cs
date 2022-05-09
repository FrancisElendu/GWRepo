using System.Net.Http.Headers;
using System.Text;

namespace GWAPICall.GWConnector.Extensions
{
    public static class HttpClientExtensions
    {
        public static HttpClient WithBasicAuth(this HttpClient client, GWCredentials gwCredentials)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                          "Basic",
                          Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format($"{gwCredentials.UserName}:{gwCredentials.Password}"))));
            return client;
        }
        public static HttpClient WithBasicAuth(this HttpClient client, string BaseUrl3, string userName, string password)
        {
            var url = $"{BaseUrl3}/accounts";
            client.DefaultRequestHeaders.Clear();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                          "Basic",
                          Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format($"{userName}:{password}"))));
            return client;
        }

        //public static HttpClient WithBasicAuth(this HttpClient client, string userName, string password, string token)
        //{
        //    client.DefaultRequestHeaders.Clear();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue($"Basic{token}");
        //                  //Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format($"{userName}:{password}"))));
        //    return client;
        //}

        public static HttpClient WithBasicAuth(this HttpClient client, string userName, string password)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                          "Basic",
                          Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format($"{userName}:{password}"))));
            return client;
        }

        public static HttpClient WithBearer(this HttpClient client, string token)
        {
            client.DefaultRequestHeaders.Clear();
            if (token.Contains("Bearer", System.StringComparison.OrdinalIgnoreCase))
            {
                token = token.Replace("Bearer", "", System.StringComparison.OrdinalIgnoreCase);
            }
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            return client;

        }
    }
}
