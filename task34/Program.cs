// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
Console.WriteLine("Введите размер массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
int count=0;

void FillArray(int[] arr) //функция для заполнения массива случайными числами
{
    for(int j = 0; j < arr.Length; j++)
    {
        arr[j] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] arr) //функция для распечатки/вывода полученного массива
{
    for(int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }
    Console.WriteLine();
}


FillArray(arr);
Console.WriteLine("массив из рандомных элементов: ");
PrintArray(arr);

for (int i = 0; i < arr.Length; i++)

if (arr[i] % 2 == 0)
count++;

Console.WriteLine($"количество четных чисел в массиве: {count}");

