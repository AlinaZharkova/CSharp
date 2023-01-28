// Задайте массив. Напишите программу,которая определяет присутствует ли заданное число в массиве.
// 4, массив [6,7,19,345,3] -> нет;  -3, массив [6,7,19,345,3] -> да.

int[] array = new int[8];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i]= rnd.Next(-99,100);
    System.Console.Write($"{array[i]}, ");
}
System.Console.WriteLine();

System.Console.Write("Введите число, которое нужно найти в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
bool pr = false;
for (int i = 0; i < array.Length; i++)
{
 if (Math.Abs(array[i])==a) pr=true;   
}
if (pr) System.Console.WriteLine("да");
else System.Console.WriteLine("нет");