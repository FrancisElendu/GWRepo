using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System.Security.Principal;

namespace GWAPICall.GWConnector.Filters
{
    public class GWAuthFilterAttribute : Attribute, IAsyncAuthorizationFilter
    {
        private GWCredentials _cred;
        public GWAuthFilterAttribute(IOptions<GWCredentials> credentials)
        {
            _cred = credentials.Value;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext actionContext)
        {

            string authHeader = actionContext.HttpContext.Request.Headers.Authorization;
            if (authHeader != null && authHeader.StartsWith("Basic"))
            {
                string encodeUserNamePassword = authHeader.Substring("Basic ".Length).Trim();
                string UserNamePassword = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encodeUserNamePassword));
                int separatorIndex = UserNamePassword.IndexOf(':');
                var username = UserNamePassword.Substring(0, separatorIndex);
                var password = UserNamePassword.Substring(separatorIndex + 1);

                if (IsAuthorizedUser(username, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);  
                    if (actionContext.HttpContext.User != null)
                    {
                        actionContext.HttpContext.User = (System.Security.Claims.ClaimsPrincipal)Thread.CurrentPrincipal;
                        return;
                    }

                }
                else
                {
                    actionContext.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    return;
                }
            }
            else
            {
                throw new Exception("The authorization header is either empty or not Basic");
            }
        }

        private bool IsAuthorizedUser(string username, string password)
        {
            if (_cred.UserName == username && _cred.Password == password) return true;
            return false;
        }
    }
}
