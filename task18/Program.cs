// Напишите программу, которая по заданному номеру четверти показывает диапазон 
//возможных координат точек в этой четверти (x и y)
Console.Write("Введите значение четверти координатной плоскости: ");
int quarter = Convert.ToInt32(Console.ReadLine());

switch(quarter) {
case 1:
    System.Console.WriteLine("x>0, y>0");
break;

case 2:
    System.Console.WriteLine("x<0, y>0");
break;

case 3:
    System.Console.WriteLine("x<0, y<0");
break;

case 4:
    System.Console.WriteLine("x>0, y<0");
break;

default:
System.Console.WriteLine("На координатной плоскости только 4 четверти! Введите число от 1 до 4");
break; }