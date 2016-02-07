using GridSearch.Domain;
using GridSearch.RestApi.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GridSearch.RestApi.Controllers
{
    public class NearbyController : ApiController
    {
        public HttpResponseMessage Get([FromUri]SearchRequest request)
        {
            AddressQuery query = new AddressQuery();
            var address = query.FindAddress(request.Thoroughfare, request.PostTown, request.PostCode);

            if (address == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "No address found matching the specified filter.");
            }

            var nearbyAddresses = query.GetNearbyAddresses(address, request.Size);
            var response = new SearchResponse(nearbyAddresses);

            return Request.CreateResponse(HttpStatusCode.OK, nearbyAddresses);
        }
    }
}
