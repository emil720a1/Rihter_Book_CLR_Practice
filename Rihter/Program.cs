using System.Drawing;
using Rihter.Labs._02_Polymorphism;

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