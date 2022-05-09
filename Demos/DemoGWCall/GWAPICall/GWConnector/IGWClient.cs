using GWAPICall.GWConnector.Models;
using GWAPICall.GWConnector.Models.AccountModel.RequestModel;
using GWAPICall.GWConnector.Models.AccountModel.ResModel;
using GWAPICall.GWConnector.Models.GWQuote;
using static GWAPICall.GWConnector.Models.HO4Product;

namespace GWAPICall.GWConnector
{
    public interface IGWClient
    {
        Task<Root> SendProductRequest();
        Task<QuoteResponse> SendGwRequest();
        Task<Response> CreateAccount(Request requestModel);
    }
}
