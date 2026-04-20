using Rectangle = Rihter.Rectangle;
using System.Drawing;

var rect = new Rectangle();
Console.WriteLine($"Rectangle ініціалізовано. Точка: ({rect.TopLeft.X}, {rect.TopLeft.Y})");

var explicitPoint = new Point(10);
Console.WriteLine($"Явна точка: ({explicitPoint.X}, {explicitPoint.Y})");

Console.WriteLine("--- Кінець експерименту ---");