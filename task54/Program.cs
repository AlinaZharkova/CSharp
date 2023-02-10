//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного
//массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Random rnd = new Random();
int m = rnd.Next(4, 9);
int n = rnd.Next(4, 9);

int[,] arr = new int[m, n];
FillArrayRandom(arr);
PrintArray(arr);
MaxToMin(arr);
System.Console.WriteLine();
PrintArray(arr);

void FillArrayRandom(int[,] array) // Функция заполнения массива рандомными числами.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-9, 10);
        }
    }
}

void PrintArray(int[,] array) // Функция распечатки массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}",(array[i, j] + " ")));
        }
        Console.WriteLine();
    }
}

void MaxToMin(int[,] array) // Функция сортировки элементов в строке по убыванию.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

