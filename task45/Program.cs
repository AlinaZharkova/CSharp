// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] array = {1,2,3,4,5,6,7};
int[] arrayCopy = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    arrayCopy[i]=array[i];
}

foreach (var item in arrayCopy)
{
    System.Console.WriteLine(item);
}