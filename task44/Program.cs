// // Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые 2 числа: 0 и 1.
// // Если n=5, то 01123, если n=7, то 0112358

// int InputNumber()
// {
//     Console.Write("Введите число: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     return x;
// }

// int n = InputNumber();
// int a = 0;
// int b = 1;
// int temp = 0;

// for (int i = 0; i < n; i++)
// {
//     Console.Write(a + " ");
//     temp = a;
//     a = b;
//     b = a + temp;
// }

// второй вариант написания программы для вывода чисел Фибоначчи

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci = new int[number];
Fibonacci[0]=0;
Fibonacci[1]=1;

Console.Write(Fibonacci[0] + "|");
Console.Write(Fibonacci[1] + "|");

for (int i = 2; i < Fibonacci.Length; i++)
{
    Fibonacci[i]=Fibonacci[i-1]+Fibonacci[i-2];
    Console.Write(Fibonacci[i] + "|");
}
System.Console.WriteLine();