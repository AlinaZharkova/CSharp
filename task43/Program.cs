// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Проверка параллельности прямых, заданных уравнениями вида y = k*x + b");
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
    System.Console.WriteLine("Прямые совпадают"); //частный случай параллельных прямых

if (k1 == k2) // по теореме, строго при условии что b1 != b2
    System.Console.WriteLine("Прямые параллельны");

else
{
    var x = (b2 - b1) / (k1 - k2);
    var y = k1 * x + b1;
    System.Console.Write($"Точка пересечения прямых: ({x};{y})");
}
