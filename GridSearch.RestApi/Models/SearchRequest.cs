using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridSearch.RestApi.Models
{
    public class SearchRequest
    {
        public string Thoroughfare { get; set; }
        public string Postcode { get; set; }
        public string Posttown { get; set; }
        public int Size { get; set; }
    }
}