// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой 
// элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rnd = new Random();
int m = rnd.Next(4, 6);
int n = rnd.Next(4, 6);
int sumRow=0;
int index = 0;
int result=0;

int[,] arr = new int[m, n];
Console.WriteLine("Исходный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-9, 10);
            Console.Write(String.Format("{0,5}",(arr[i, j] + " "))); //выводим полученный массив для просмотра элементов
        }
        System.Console.WriteLine();
    }

System.Console.WriteLine();


for (int i = 0; i < arr.GetLength(0); i++)
{ 
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sumRow += arr[i, j]; 
    }
    Console.Write("\nSum of row {0} is : {1}; ", i, sumRow); //выводим сумму элементов каждой строки (с указанием номера строки)
    if (i == 0) result = sumRow;
        else if (sumRow < result)
        {
            result = sumRow;
            index = i;
        }
}
System.Console.WriteLine();
System.Console.WriteLine($"\nСтрока с наименьшей суммой элементов находится под индексом {index}");   

