//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
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
System.Console.WriteLine("Суббота - выходной день!");
break;


case 7:
System.Console.WriteLine("Воскресенье- выходной день!");
break;


default:
System.Console.WriteLine("Введите число 1-7");
break;
}
