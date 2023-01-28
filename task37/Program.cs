// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.

System.Console.WriteLine("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
Random rnd = new Random();
for (int i = 0;  i<len; i++)
{
 array[i]= rnd.Next(99);
 System.Console.Write($"{array[i]}, ");
}
System.Console.WriteLine();

for (int i = 0; i < len/2; i++)
{
    System.Console.Write($"{array[i]*array[i]-1-i}, ");
}
if (len%2!=0) System.Console.Write(array[len/2]);
