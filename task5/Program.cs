//Написать программу, которая на вход принимает число N, а на выходе выдает все целые числа от -N до N.
System.Console.WriteLine("Введите число:");

int a = Convert.ToInt32(Console.ReadLine());

int i = -1 * a;

while (i <= a)
{
    System.Console.Write(i + " ");
    i++;
}
