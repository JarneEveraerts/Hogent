namespace Fedex;

public abstract class Item
{
    public virtual void addItem(Item item)
    {
    }

    public virtual void removeItem(Item item)
    {
    }

    public virtual double givePrice()
    {
    }
}