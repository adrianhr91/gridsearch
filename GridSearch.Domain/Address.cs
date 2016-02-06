using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSearch.Domain
{
    public class Address
    {
        public string Thoroughfare { get; set; }
        public string Posttown { get; set; }
        public string Postcode { get; set; }
        public int Easting { get; set; }
        public int Northing { get; set; }
    }
}
