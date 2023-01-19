//Написать программу, которая принимает на вход координаты точки (x и y), причем x!=0, y!=0 и выдает
// номер четверти плоскости, в которой находится точка.
Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    System.Console.WriteLine("1 quarter");
}
else if (x<0 && y>0)
{
    System.Console.WriteLine("2 quarter");
}
else if (x<0 && y<0)
{
    System.Console.WriteLine("3 quarter");
}
else if (x>0 && y<0)
{
    System.Console.WriteLine("4 quarter");
}