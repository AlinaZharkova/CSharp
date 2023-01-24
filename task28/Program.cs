// Напишите программу, которая принимает на вход число (N) и выдает произведение чисел от 1 до N (4->24, 5->120)
System.Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int product=1;
for (int i = 1; i <= N; i++)
{
product=product*i;    
}
System.Console.WriteLine("product = " +product);