namespace Rihter.Labs._03_OperatorsAndExtensions;

public static class WeightExtensions
{
    public static Weight ToWeight(this double value)
    {
        return new Weight(value);
    }
}