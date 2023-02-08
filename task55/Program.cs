//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

Random rnd = new Random();
int m = rnd.Next(4, 8);
int n = rnd.Next(4, 8);

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(-9, 10);
        Console.Write(String.Format("{0,9}", (arr[i, j] + " ")));
    }
    System.Console.WriteLine();
}
if (m!=n) 
{
    System.Console.WriteLine("Массив не квадратный! Корректная перестановка невозможна!");
    return;
}

// int temp =0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = i; j < arr.GetLength(1); j++)
    {
        // temp = arr[i, j];
        // arr[i, j] = arr[j, i];
        // arr[j, i] = temp;
        (arr[i,j], arr[j,i])=(arr[j,i], arr[i,j]);

    }
}
System.Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,9}", (arr[i, j] + " ")));
    }
    Console.WriteLine();
}

