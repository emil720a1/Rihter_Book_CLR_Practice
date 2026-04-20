namespace Rihter;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; } 
    
    // Статичний конструктор
    static Point()
    {
        Console.WriteLine("=> Спрацював статичний конструктор (.cctor) струкури Point!");
    }

    public Point(int x)
    {
        // Цей рядок занулює ВСІ поля (X та Y стають 0)
        this = new Point();
        
        // Потім присвоємо потрібне значення
        X = x;
        // Y залишиться 0 (або 5, якщо new Point() викликав конструктор вище)
    }
}