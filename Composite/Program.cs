public class Program
{
    public static void Main(string[] args) 
    {
        Client client = new();

        IProduct laptop = new Product("Laptop", 1200);
        IProduct smartphone = new Product("Smartphone", 800);
        IProduct headset = new Product("Headset", 150);

        Category electronics = new("Electronics");
        electronics.Add(laptop);
        electronics.Add(smartphone);

        IProduct mouse = new Product("Mouse", 50);
        Category accessories = new("Accessories");
        accessories.Add(mouse);

        Category shop = new Category("Shop");
        shop.Add(electronics);
        shop.Add(accessories);

        client.DisplayProducts(shop);
        Console.WriteLine($"Total Price: ${client.GetTotalPrice(shop)}");
    }
}