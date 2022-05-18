namespace BedAndBreakfastApp;

public class BoekingMidWeek : IBoeking
{
    public BoekingMidWeek()
    {
        VoorzieMaaltijden();
        VoorzieActiviteit();
        MaakKamersVrij();
    }

    public void VoorzieActiviteit()
    {
        Console.WriteLine("activiteit is voorzien voor Midweek");
    }

    public void MaakKamersVrij()
    {
        Console.WriteLine("kamer is voorzien voor Midweek");
    }

    public void VoorzieMaaltijden()
    {
        Console.WriteLine("maaltijden zijn voorzien voor Midweek");
    }
}