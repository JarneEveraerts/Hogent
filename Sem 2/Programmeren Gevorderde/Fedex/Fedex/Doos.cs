namespace Fedex;

public class Box : Item
{
    public List<Item> items { get; set; } = new();

    public void addItem(Item item)
    {
        items.Add(item);
    }

    public void removeItem(Item item)
    {
        items.Remove(item);
    }

    public override double givePrice()
    {
        double price = 0;
        Console.WriteLine(GetType().Name);
        foreach (var VARIABLE in items)
        {
            price += VARIABLE.givePrice();
        }

        return price;
    }
}