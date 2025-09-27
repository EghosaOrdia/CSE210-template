public class Order
{
    private List<Product> _products;
    private List<Customer> _customers;

    public float GetTotalCost()
    {
        float total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        return total;
    }

    public List<PackingLabel> GetPackingLabel()
    {
        List<PackingLabel> packingLabels = _products
        .Select(p => new PackingLabel { _name = p.GetName(), _id = p.GetId() })
        .ToList();
        return packingLabels;
    }

    public List<ShippingLabel> GetShippingLabel()
    {
        List<ShippingLabel> shippingLabels = _customers
        .Select(c => new ShippingLabel { _name = c.GetName(), _address = c.GetAddress() })
        .ToList();
        return shippingLabels;
    }
}