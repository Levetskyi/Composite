public class Client
{
    public void DisplayProducts(IProduct product)
    {
        Console.WriteLine(product.GetName());
    }

    public double GetTotalPrice(IProduct product)
    {
        return product.GetPrice();
    }
}