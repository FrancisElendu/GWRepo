namespace GWAPICall.GWConnector
{
    public class GWCredentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string BaseUrl1 { get; set; }
        //public string BaseUrl2 { get; set; }
        public string BaseUrl3 { get; set; }

        public string AccountApiBaseUrl { get; set; }

        public string TokenGenUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public string GrantType { get; set; }

        public string Scope { get; set; }
    }
}
