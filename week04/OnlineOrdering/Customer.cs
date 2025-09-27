public class Customer
{
    private string _name;
    private Address _address;

    public Boolean LivesInUSA()
    {
        return _address.LivesInUSA();
    }

    public string GetName()
    {
        return _name;
    }
    
    public Address GetAddress()
    {
        return _address;
    }
}