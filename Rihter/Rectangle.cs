namespace Rihter;

public class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle()
    {
        // Тут ми нічого не робимо, CLR просто занулює пам'ять
    }
}