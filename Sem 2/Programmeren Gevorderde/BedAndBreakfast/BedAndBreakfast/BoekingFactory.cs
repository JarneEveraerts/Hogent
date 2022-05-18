namespace BedAndBreakfastApp;

public static class BoekingFactory
{
    public static IBoeking MaakBoeking(BoekingType type)
    {
        return type switch
        {
            BoekingType.Midweek => new BoekingMidWeek(),
            BoekingType.Week => new BoekingWeek(),
            BoekingType.Weekend => new BoekingWeekend(),
            _ => throw new ArgumentException()
        };
    }
}