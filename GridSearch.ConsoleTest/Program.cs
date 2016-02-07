using GridSearch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSearch.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new GridSearchDb();

            AddressQuery query = new AddressQuery();

            var addresses = query.FindNearbyAddresses(new Address() { Easting = 324423, Northing = 664988 },
                3000);

            foreach (var address in addresses)
            {
                Console.WriteLine(address.Thoroughfare);
            }
        }
    }
}
