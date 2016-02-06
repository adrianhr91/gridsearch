using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridSearch.RestApi.Models
{
    public class SearchResponse
    {
        public List<Address> Addresses { get; set; }

        public SearchResponse()
        {
            Addresses = new List<Address>();
        }
    }

    public class Address
    {
        public string Thoroughfare { get; set; }
        public string Postcode { get; set; }
        public string Posttown { get; set; }
        public int Easting { get; set; }
        public int Northing { get; set; }
    }
}