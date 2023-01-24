// Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке.
int[] a = new int[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++)
{
    a[i]= rnd.Next(0,2);
    System.Console.WriteLine(a[i]);
}