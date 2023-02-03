//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.Write("Задайте число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int[,] array = new int[m, n];
double sum = 0;
double average =0;

FillArray(array);

void FillArray(int[,] arr) //заполняем массив случайными числами 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-99, 100);
            Console.Write(arr[i, j] + " "); //выводим полученный массив для просмотра элементов
        }
        System.Console.WriteLine();
    }
}


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[j, i]; //суммируем все элементы массива по строкам и столбцам
        average = Math.Round(sum/array.GetLength(0),2);//среднее арифметическое, округленное до 2 знака
    }
    Console.Write((average) + "; ");
}



