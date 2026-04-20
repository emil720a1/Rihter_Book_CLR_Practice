namespace Rihter.Labs._01_StructsAndStatic;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; } 
    
    // Статичний конструктор
    static Point() => Console.WriteLine("LOG: Point .cctor executed!");

    // Конструктор без параметрів (доступний з C# 10)
    public Point()
    {
        X = 5;
        Y = 5;
    }
    public Point(int x)
    {
        // ХАК РІХТЕРА: Викликаємо Point() через this, щоб заповнити дефолти
        this = new Point();
        X = x;
    }
}