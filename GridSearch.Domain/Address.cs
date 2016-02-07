using System;

namespace GridSearch.Domain
{
    public class Address
    {
        public string Thoroughfare { get; set; }
        public string Posttown { get; set; }
        public string Postcode { get; set; }
        public int Easting { get; set; }
        public int Northing { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Address;

            if (other == null)
            {
                return false;
            }
            else if (this.Thoroughfare == other.Thoroughfare &&
                this.Posttown == other.Posttown &&
                this.Postcode == other.Postcode)
            {
                return true;
            }

            return false;
        }
    }
}
