//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку.

Random rnd = new Random();
int m = rnd.Next(4, 4);
int n = rnd.Next(4, 4);

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(-9, 10);
        Console.Write(String.Format("{0,9}",(arr[i, j] + " ")));
    }
    System.Console.WriteLine();
}


for (int j = 0; j < arr.GetLength(1); j++)
{
    (arr[0, j], arr[m - 1, j]) = (arr[m - 1, j], arr[0, j]);
}
Console.WriteLine();


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,9}", (arr[i, j] + " ")));
    }
    Console.WriteLine();
}



