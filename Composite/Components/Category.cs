using System.Text;

public partial class Category(string name) : IProduct
{
    private string _name = name;
    private List<IProduct> _products = new();

    public void Add(IProduct product)
    {
        _products.Add(product);
    }

    public void Remove(IProduct product)
    {
        _products.Remove(product);
    }

    public string GetName()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine($"Category: {_name}");

        foreach (IProduct product in _products) 
        {
            stringBuilder.AppendLine ($" - {product.GetName()}");
        }

        return stringBuilder.ToString();
    }

    public double GetPrice()
    {
        double totalPrice = 0;

        foreach (IProduct product in _products)
        {
            totalPrice += product.GetPrice();
        }

        return totalPrice;
    }
}