﻿//Написать программу, которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго.
Console.Clear();
Console.WriteLine("первое число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("второе число");
int b = Convert.ToInt32 (Console.ReadLine());
if (a==b*b) 
{    
Console.WriteLine($"{a} квадрат {b}");
}
else
{
System.Console.WriteLine("Не квадрат числа!");
}