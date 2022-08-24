// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введи k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");