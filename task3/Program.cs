﻿//Написать программу, которая будет выдавать название дня недели по заданному номеру.
Console.Clear();

System.Console.WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

switch(a)
{
case 1:
System.Console.WriteLine("Понедельник");
break;

case 2:
System.Console.WriteLine("Вторник");
break;

case 3:
System.Console.WriteLine("Среда");
break;

case 4:
System.Console.WriteLine("ПЧетверг");
break;

case 5:
System.Console.WriteLine("Пятница");
break;

case 6:
System.Console.WriteLine("Суббота");
break;

case 7:
System.Console.WriteLine("Воскресенье");
break;

default:
System.Console.WriteLine("ВВедите число 1-7");
break;

}