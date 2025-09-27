public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        // Add shipping cost
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public List<PackingLabel> GetPackingLabel()
    {
        return _products
          .Select(p => new PackingLabel { _name = p.GetName(), _id = p.GetId() })
          .ToList();
       
    }

    public ShippingLabel GetShippingLabel()
    {
        return new ShippingLabel
        {
            _name = _customer.GetName(),
            _address = _customer.GetAddress()
        };
    }
}