using Rectangle = Rihter.Rectangle;
using System.Drawing;

/*
 * TOPIC: Struct Initialization and Type Constructors (.cctor)
 * LEARNED FROM: Richter, Chapter 8
 */

var rect = new Rectangle();
Console.WriteLine($"[1] Rectangle field init: ({rect.TopLeft.X}, {rect.TopLeft.Y})");
// Виведе 0,0, бо CLR занулила пам'ять, не викликаючи Point()


// Експеримент 2: Явний виклик конструктора
var p = new Point(10);
Console.WriteLine($"[2] Explicit point init: ({p.X}, {p.Y})");
// Виведе 10,5 (10 - параметр, 5 - прийшло з 'this' = new Point()')
Console.WriteLine("--- Кінець експерименту ---");