using System;

namespace Lesson06
{
    class Address
    {
        // Properties:
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private int homeNumber;
        public int HomeNumber
        {
            get { return homeNumber; }
            set {
                if(value > 0)
                homeNumber = value;
            }
        }

        // Constructor:
        public Address(string country, string city, string street, int homeNumber)
        {
            Country = country;
            City = city;
            Street = street;
            HomeNumber = homeNumber;
        }

        // Get info:
        public string GetInfo()
        {
            return $"Address: {Country}: {City}, {Street}, {HomeNumber}";
        }

    }
}
