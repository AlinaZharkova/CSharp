// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите размер массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[len];
int sum = 0;

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

for (int i = 1; i < arr.Length; i+=2)
    sum = sum + arr[i];

    Console.WriteLine($"сумма элементов, cтоящих на нечётных позициях = {sum}");

