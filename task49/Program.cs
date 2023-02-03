// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты.
// [1 4 7 2  5 9 2 3  8 4 2 4] -> [1 4 7 2  5 81 2 9  8 4 2 4]

System.Console.Write("Задайте число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n]; 
Random rnd = new Random();

 for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            array[i, j] = rnd.Next(1, 10);
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }

System.Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (i % 2 == 0 && j % 2 == 0) 
            array[i, j] = array[i, j]*array[i,j];
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
