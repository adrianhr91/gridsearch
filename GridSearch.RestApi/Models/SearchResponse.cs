using GridSearch.Domain;
using System.Collections.Generic;

namespace GridSearch.RestApi.Models
{
    public class SearchResponse
    {
        public List<Address> Addresses { get; private set; }

        public SearchResponse(List<Address> addresses)
        {
            Addresses = addresses ?? new List<Address>();
        }
    }
}