namespace BedAndBreakfastApp;

public class BoekingWeekend : IBoeking
{
    public BoekingWeekend()
    {
        VoorzieMaaltijden();
        VoorzieActiviteit();
        MaakKamersVrij();
    }

    public void VoorzieActiviteit()
    {
        Console.WriteLine("activiteit is voorzien voor weekend");
    }

    public void MaakKamersVrij()
    {
        Console.WriteLine("kamer is voorzien voor weekend");
    }

    public void VoorzieMaaltijden()
    {
        Console.WriteLine("maaltijden zijn voorzien voor weekend");
    }
}