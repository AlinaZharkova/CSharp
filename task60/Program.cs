// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Random rnd = new Random();
int m = rnd.Next(4, 9);
int n = rnd.Next(4, 9);
int l = rnd.Next(4, 9);


int[,,] ArrayGenerator(int rows, int columns, int height, int min, int max) //генератор массивов
{
    int[,,] array = new int[rows, columns, height];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return array;
}


void PrintArray(int[,,] array) // Функция распечатки массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],1}| ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3D = ArrayGenerator(2, 2, 2, 10, 99);
PrintArray(array3D);
System.Console.WriteLine();

void Show3dArray(int[,,] array) // показываем двумерный массив 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("[" + i + "," + j + "," + k + "]" + array[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Show3dArray(array3D);