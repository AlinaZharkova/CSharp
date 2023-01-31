// Нвпишите программу, которая пеевернет одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.) [1,2,3,4,5]->[5,4,3,2,1]

System.Console.Write("Размер массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
Random rnd = new Random();

FillRandomArray(array, len);
PrintArray(array, len);
//ReversArray(array, len);
System.Console.WriteLine();
RecurseRevers(array, 0, array.Length-1);
PrintArray(array, len);

// void ReversArray(int[] array, int length) //фуекция для разворота массива
// {
//     int temp;
//     for (int i = 0; i < length / 2; i++)
//     {
//         temp = array[i];
//         array[i] = array[length - 1 - i];
//         array[length - 1 - i] = temp;
//     }
// }

void FillRandomArray(int[] array, int length) //функция для заполнения массива случайными числами от 0 до 100
{
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100);

    }
}

void PrintArray(int[] array, int length) //функция для распечатки массива
{
    System.Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}]");
    }
}

void RecurseRevers(int[] array, int i, int j) //функция рекурсии
{
    if (i>=j)
    {
        return;
    }
    else
    {
int tmp = array[i];
array[i] = array[j];
array[j]=tmp;
RecurseRevers(array, i+1, j-1);
    }
}

