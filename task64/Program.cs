//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число от 1: ");
int N = Convert.ToInt32(Console.ReadLine());
void ReverseNumbers(int N)
{
    if (N <= 0) 
    {
        Console.WriteLine($"{N} - не натуральное число");
        return;
    }
    else 
    {
        System.Console.Write(N + " ");
        ReverseNumbers(N - 1);
    }
}
 
 ReverseNumbers(N);
 

