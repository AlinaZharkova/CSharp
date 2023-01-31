// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива:  ");
int len = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[len];

void FillArray(double[] arr) //функция для заполнения массива случайными числами
{
    for(int j = 0; j < arr.Length; j++)
    {
        arr[j] = Convert.ToDouble(new Random().Next(100))/10;
    }
}

void PrintArray(double[] arr) //функция для распечатки/вывода полученного массива
{
    for(int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + "; ");
    }
    Console.WriteLine();
}

FillArray(arr);
Console.WriteLine($"массив из рандомных элементов: ");
PrintArray(arr);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        {
            max = arr[i];
        }
    if (arr[i] < min)
        {
            min = arr[i];
        }
}

Console.WriteLine($"Максимальное значение = {max}; минимальное значение = {min}.");
Console.WriteLine($"Max - Min = {max - min}");


//второй вариант (более правильный) написания программы для генерации случайных вещественных чисел:
// double[] arr = new double[10];

// void FillArray(double[] arr)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]=genRndDouble(-100, 100, rnd);
    
//     }
// }

// FillArray(arr);

// foreach (var item in arr)
// {
//     System.Console.WriteLine($"{item:f2}"); // :f2 - округление числа до 2 знака после запятой
// }

// double genRndDouble(int a, int b, Random rnd)
// {
//     double rndDouble = a + rnd.NextDouble() * (b-a);
//     return rndDouble;
// }