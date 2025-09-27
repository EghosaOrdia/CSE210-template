public class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;

    public float GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }
}