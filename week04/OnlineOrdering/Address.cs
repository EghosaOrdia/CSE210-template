public class Address
{
    private string _streetAddress;
    private string _city;
    private string _country;

    public Boolean LivesInUSA()
    {
        return _country == "USA";
    }
}