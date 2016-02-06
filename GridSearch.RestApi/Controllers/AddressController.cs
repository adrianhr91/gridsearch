using GridSearch.RestApi.Models;
using System.Web.Http;

namespace GridSearch.RestApi.Controllers
{
    public class NearbyController : ApiController
    {
        public SearchResponse Get([FromUri]SearchRequest request)
        {
            return null;
        }
    }
}
