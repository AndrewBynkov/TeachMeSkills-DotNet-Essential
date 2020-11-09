namespace TeachMeSkills.DotNet.Task4
{
    public class Address
    {
        public Address(int index, string country, string city, string street, string house, string apartment)
        {
            _index = index;
            _country = country;
            _city = city;
            _street = street;
            _house = house;
            _apartment = apartment;

            AddToProperties();
        }

        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private string _apartment;

        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        private void AddToProperties()
        {
            Index = _index;
            Country = _country;
            City = _city;
            Street = _street;
            House = _house;
            Apartment = _apartment;
        }
    }
}
