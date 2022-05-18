namespace Fedex;

public abstract class Product : Item
{
    private double Price;

    public Product(double price)
    {
        Price = price;
    }

    public double givePrice()
    {
        Console.WriteLine(GetType().Name + $" Price" + Price);
        return Price;
    }
}