//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

System.Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int[,] array = new int[6, 6];

FillArray(array);
PrintArray(array);

if (m < array.GetLength(0) && n < array.GetLength(1)) Console.WriteLine(array[m, n]);
else Console.WriteLine($"{m}{n} -> такого числа в массиве нет");


void FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j]= rnd.Next(-99,100);
    }
    System.Console.WriteLine();
}
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}
