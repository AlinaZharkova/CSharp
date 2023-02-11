//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Random rnd = new Random();
int minValue= 2;
int maxValue= 4;
System.Console.Write("Задайте число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Задайте число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первый массив: ");
int[,] array1 = ArrayGenerator(rows, columns, minValue, maxValue);

Console.WriteLine("\nВторой массив: ");
int[,] array2 = ArrayGenerator(rows, columns, 1, 10);

int[,] productArray = new int[rows, columns];

if (rows != columns)
    {
        Console.WriteLine("Невозможно вычислить! Введите число строк = числу столбцов.");
        return;
    }
    else

Console.WriteLine("\nПроизведение первого массива со вторым: ");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        productArray[i, j]=0;
        for (int k = 0; k < array2.GetLength(1); k++)
        {
            productArray[i, j]+= array1[i, k] * array2[k, j];
        }
        Console.Write(String.Format("{0,5}", productArray[i, j] + " "));
    }
    Console.WriteLine();
}


int[,] ArrayGenerator(int lenghtRows, int lenghtColum, int min, int max) //генератор массивов
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
            Console.Write(String.Format("{0,5}", array[i, j] + " "));
        }
        System.Console.WriteLine();
    }
    return array;
}