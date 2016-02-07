using GridSearch.Domain.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace GridSearch.Domain
{
    public class AddressQuery
    {
        public Address FindAddress(string thoroughfare, string postTown, string postCode)
        {
            using (var context = new GridSearchDb())
            {
                return context.Addresses.FirstOrDefault(
                    address =>
                address.Thoroughfare.ToLower() == thoroughfare &&
                address.Posttown.ToLower() == postTown &&
                address.Postcode.ToLower() == postCode);
            }
        }

        public List<Address> FindNearbyAddresses(Address address, int squareSize)
        {
            var nearbyAddresses = new List<Address>();
            var searchSquare = new Square(address.Easting, address.Northing, squareSize);

            using (var context = new GridSearchDb())
            {
                nearbyAddresses = context.Addresses
                    .AsEnumerable()
                    .Where(a => Square.IsInside(a.Easting, a.Northing, searchSquare))
                    .ToList();
            }

            nearbyAddresses.RemoveAll(a => a.Equals(address)); // exclude original address from search

            return nearbyAddresses;
        }
    }
}
