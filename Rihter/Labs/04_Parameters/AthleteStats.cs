namespace Rihter.Labs._04_Parameters;

public readonly struct AthleteStats
{
    public readonly double SquatMax;
    public readonly double BenchMax;
    public readonly double DeadliftMax;
    public readonly string Name;
    public readonly string Federation;

    public AthleteStats(double sq, double bp, double dl, string name, string fed)
    {
        SquatMax = sq;
        BenchMax = bp;
        DeadliftMax = dl;
        Name = name;
        Federation = fed;
    }
}