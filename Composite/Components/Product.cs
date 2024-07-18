public class Product(string name, double price) : IProduct
{
    private string _name = name;
    private double _price = price;

    public string GetName()
    {
        return $"Product: {_name}, Price: ${_price}";
    }

    public double GetPrice()
    {
        return _price;
    }
}