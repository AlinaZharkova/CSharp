// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
System.Console.Write("Задайте число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];
Random rnd = new Random();

double genRndDouble(int a, int b, Random rnd) //функция для генерации случайных вещественных чисел
{
    double rndDouble = a + rnd.NextDouble() * (b-a);
    return rndDouble;
}

void FillArray(double[,] arr) //функция для заполнения массива числами
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i,j]=genRndDouble(-100, 100, rnd);
      System.Console.Write(arr[i,j]+" ");
    }
    System.Console.WriteLine();
}
}

void PrintArray(double[,] arr) //функция для заполнения массива числами
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(Math.Round(arr[i,j],2) + " " );
    }
    System.Console.WriteLine();
}
}

FillArray(array);
Console.WriteLine($"массив из случайных вещественных чисел: ");
PrintArray(array);

