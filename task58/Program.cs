//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Random rnd = new Random();
int rows = 4;
int columns = 4;
int arrayMin = -5;
int arrayMax = 5;


Console.WriteLine("Первый массив: ");
int[,] array1 = ArrayGenerator(rows, columns, arrayMax, arrayMin);
Console.WriteLine("\nВторой массив: ");
int[,] array2 = ArrayGenerator(rows, columns, arrayMax, arrayMin);

int[,] productArray = new int[rows, columns];

Console.WriteLine("\nПроизведение первого массива со вторым: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        productArray[i, j] = array1[i, j] * array2[i, j];
        Console.Write(String.Format("{0,5}", productArray[i, j] + " "));
    }
    Console.WriteLine();
}


int[,] ArrayGenerator(int lenghtRows, int lenghtColum, int max, int min) //генератор массивов
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max);
            Console.Write(String.Format("{0,5}", array[i, j] + " "));
        }
        System.Console.WriteLine();
    }
    return array;
}