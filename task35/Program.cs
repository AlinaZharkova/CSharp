// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99]
int[] array = new int[123];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,124);
    System.Console.Write($"{array[i]}, ");
    if (array[i]>9 && array[i]<100) count+=1;
}
System.Console.WriteLine();
System.Console.WriteLine("count = " + count);
