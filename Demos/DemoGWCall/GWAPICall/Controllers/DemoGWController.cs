using GWAPICall.GWConnector;
using GWAPICall.GWConnector.Models;
using GWAPICall.GWConnector.Models.AccountModel.RequestModel;
using GWAPICall.GWConnector.Models.AccountModel.ResModel;
using GWAPICall.GWConnector.Models.GWQuote;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static GWAPICall.GWConnector.Models.HO4Product;

namespace GWAPICall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoGWController : ControllerBase
    {
        private readonly IGWClient _gwClient;
        public DemoGWController(IGWClient gwClient)
        {
            _gwClient = gwClient;
        }


        [HttpGet("GetGWProduct")]
        public async Task<Root> GetGwProduct()
        {
            var res = await _gwClient.SendProductRequest();
            return res;
        }




        [HttpGet("GetGWQuote")]
        public async Task<QuoteResponse> GetGwQuote()
        {
            return await _gwClient.SendGwRequest();
        }
    }
}
