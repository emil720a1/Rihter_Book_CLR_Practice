using System.Drawing;
using Rihter.Labs._02_Polymorphism;
using Rihter.Labs._03_OperatorsAndExtensions;
using Rihter.Labs._04_Parameters;

Console.WriteLine("=== CLR Deep Dive: Lab  Runner ===\n");

RunStructLab();

Console.WriteLine("\n----------------------------------\n");

RunPolymorphismLab();

void RunStructLab()
{
    Console.WriteLine(">>> LAB 01: Struct Initialization");
    var rect = new Rihter.Labs._01_StructsAndStatic.Rectangle();
    Console.WriteLine($"Rectangle TopLeft: {rect.TopLeft.X}, {rect.TopLeft.Y} (Expected 0,0)");
}

void RunPolymorphismLab()
{
    Console.WriteLine(">>> LAB 02: Polymorphism"); 

    Phone myDevice = new SmartPhone();
    myDevice.Call();
    myDevice.SendSms();
    
    Console.WriteLine("\n--- Casting to SmartPhone ---");
    ((SmartPhone)myDevice).Call();

}

void RunOperatorsLab()
{
    Console.WriteLine(">>> LAB 03: Operators and Extensions");
    
    // Використовуємо implicit (неявне): int стає Weight автоматично
    Weight bar = 20;

    // Використовуємо метод розширення
    Weight plates = 100.5.ToWeight();
    
    // Використовуємо оператор +
    Weight total = bar + plates;
    
    Console.WriteLine($"Total weight: {total}");
    
    // Використовуємо explicit (явне): треба дужки (double)
    double pounds = (double)total;
    Console.WriteLine($"Weight in pounds: {pounds:F2} lbs");
}


void RunParametersLab()
{
    Console.WriteLine(">>> LAB 04: Parameters (ref, out, in)");

    // 1. Експеримент з 'ref'
    double barbellWeight = 180.0;
    CompetitionLogic.AdjustWeight(ref barbellWeight, 2.5);

    // 2. Експеримент з 'out'
    if (CompetitionLogic.TryAttempt(barbellWeight, 200.0, out string resultMessage))
    {
        Console.WriteLine($"Result: {resultMessage}");
    }
    
    // 3. Експеримент з 'in'
    var athlete = new AthleteStats(200.0, 150.0, 260.0, "Oleh", "IPF");
    CompetitionLogic.PrintAthleteInfo(in athlete);
}