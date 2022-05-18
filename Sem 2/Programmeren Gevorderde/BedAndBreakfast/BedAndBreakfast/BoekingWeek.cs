namespace BedAndBreakfastApp;

public class BoekingWeek : IBoeking
{
    public BoekingWeek()
    {
        VoorzieMaaltijden();
        VoorzieActiviteit();
        MaakKamersVrij();
    }

    public void VoorzieActiviteit()
    {
        Console.WriteLine("activiteit is voorzien voor week");
    }

    public void MaakKamersVrij()
    {
        Console.WriteLine("kamer is voorzien voor week");
    }

    public void VoorzieMaaltijden()
    {
        Console.WriteLine("maaltijden zijn voorzien voor week");
    }
}