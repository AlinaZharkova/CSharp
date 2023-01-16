//Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите число:");

int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < a)
{
    i += 1;
    System.Console.Write(i + " ");
    i++;
}

