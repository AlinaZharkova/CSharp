// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А (7->28, 4->10, 8->36)
System.Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
int sum=0;
for (int i = 1; i <= a; i++)
{
sum+=i;    
}
System.Console.WriteLine("sum = " +sum);