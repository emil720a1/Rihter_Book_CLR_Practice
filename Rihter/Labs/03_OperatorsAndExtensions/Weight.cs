namespace Rihter.Labs._03_OperatorsAndExtensions;

public class Weight
{
    private readonly double _kilograms;

    private static double _standartBarWeight;

    static Weight()
    {
        _standartBarWeight = 20.0; // Стандартний гриф
        Console.WriteLine("LOG: Static constructors Weight(.cctor initialized standard bar.");
    }
    
    public Weight(double kilograms) => _kilograms = kilograms;

    // 1. Перезавантаження оператора + (op_Addition)
    public static Weight operator +(Weight w1, Weight w2) => new(w1._kilograms + w2._kilograms);
    
    // 2. Неявне перетворення (implicit): з int в Weight (безпечно)
    public static implicit operator Weight(int kg) => new(kg);
    
    // 3. Явне перетворення (explicit): з Weight в double (lbs - фунти)
    // Тут можлива втрата точності, тому explicit
    public static explicit operator double(Weight w) => w._kilograms * 2.20462;

    public double ToPounds() => (double)this;
    
    public override string ToString() => $"{_kilograms}kg";
    
    
}