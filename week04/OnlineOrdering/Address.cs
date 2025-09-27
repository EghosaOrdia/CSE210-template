public class Address
{
    private string _streetAddress;
    private string _city;
    private string _country;

    public Address(string street, string city, string country)
    {
        _streetAddress = street;
        _city = city;
        _country = country;
    }

    public bool LivesInUSA()
    {
        return _country == "USA";
    }

    public override string ToString()
    {
        return $"{_streetAddress}, {_city}, {_country}";
    }
}