// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле Amn = m+n. 
// Выведите полученный массив на экран.

System.Console.Write("Задайте число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте число n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}