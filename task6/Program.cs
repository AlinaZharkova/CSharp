//Написать программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2==0)
{
  System.Console.Write("четное число");
}
else
{
  System.Console.Write("нечетное число");
}
