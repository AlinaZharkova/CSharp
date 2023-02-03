// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0), (1,1), (2,2) и т.д.) 

System.Console.Write("Задайте число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n]; 
Random rnd = new Random();
int sum=0;

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
            if (i==j)  sum+= array[i,j];  
        }
    }
  System.Console.WriteLine(sum);
