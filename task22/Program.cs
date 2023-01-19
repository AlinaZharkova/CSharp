//Написать программу, которая на вход принимает число (N), а на выходе выдвет таблицу квадратов чисел от 1 до N. (5-> 1,4,9,16,25)
System.Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int square = 1;
int i=1;
    
while (i <= n)
{
    square = i*i;
    i++;
    System.Console.Write($"{square}");
} 
