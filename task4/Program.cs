//Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число:");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if (secondNum > max)
{
    max= secondNum;
}

if (thirdNum > max)
{
    max= thirdNum;
}

Console.WriteLine("Максимальное из введённых чисел: " + max);