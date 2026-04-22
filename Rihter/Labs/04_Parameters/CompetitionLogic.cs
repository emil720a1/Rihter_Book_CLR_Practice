namespace Rihter.Labs._04_Parameters;

public static class CompetitionLogic
{
    public static void AdjustWeight(ref double currentWeight, double increment)
    {
        currentWeight += increment;
        Console.WriteLine($"LOG: Weight adjusted to {currentWeight:F2}kg.");
    }

    public static bool TryAttempt(double weight, double athleteMax, out string message)
    {
        if (weight <= athleteMax)
        {
            message = "Yeah Buddy! Light weight!";
            return true;
        }
        message = "Nope, too heavy!";
        return false;
    }

    public static void PrintAthleteInfo(in AthleteStats stats)
    {
        Console.WriteLine($"Athlete: {stats.Name} (Federation: {stats.Federation})");
    }
}