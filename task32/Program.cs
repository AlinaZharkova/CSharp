// Напишите программу замены элементов массива: положительные элементы замените на соответсвующие 
//отрицательные и наоброт. [-4,-8,8,2] -> [4,8,-8,-2]

int[] array=new int[8];
Random rnd=new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i]=rnd.Next(-99,100);
    System.Console.Write($"{array[i]}, ");
}
System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i]=array[i]*-1;
    System.Console.Write($"{array[i]}, ");
}
