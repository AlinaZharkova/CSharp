//Написать программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
System.Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if ((a < 100) || (a > 999))
{
    System.Console.WriteLine("ошибка!");
}
else
{
    int b = a % 10;
System.Console.WriteLine(b);
}