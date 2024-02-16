class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        return totalCost + (_customer.IsInUSA() ? 5 : 35);
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer Name: {_customer.GetName()}\n";
        label += $"Customer Address: {_customer.GetAddress().GetFullAddress()}\n";

        return label;
    }
}
