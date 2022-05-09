using GWAPICall.GWConnector;
using GWAPICall.GWConnector.Filters;
using GWAPICall.GWConnector.Models.AccountModel.RequestModel;
using GWAPICall.GWConnector.Models.AccountModel.ResModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GWAPICall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IGWClient _gwClient;
        public AccountController(IGWClient gwClient)
        {
            _gwClient = gwClient;
        }

        [HttpPost("CreateAccount")]
        [TypeFilter(typeof(GWAuthFilterAttribute))]
        public async Task<ActionResult<Response>> CreateAccount([FromBody] Request requestModel)
        {
            var res = await _gwClient.CreateAccount(requestModel);
            if (res.data == null)
            {
                return BadRequest(res);
            }
            return Created("", res);
        }
    }
}
