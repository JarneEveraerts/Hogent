namespace BedAndBreakfastApp;

public class BedAndBreakfast
{
    public IBoeking Boeking { get; set; }

    public BedAndBreakfast(BoekingType type)
    {
        Reserveer(type);
    }

    public void VerwisselBoeking(BoekingType type)
    {
        Reserveer(type);
    }

    private void Reserveer(BoekingType type)
    {
        Boeking = BoekingFactory.MaakBoeking(type);
    }
}