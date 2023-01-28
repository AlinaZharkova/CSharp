// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива.
int[] arr=new int[12];
int sumOtric=0;
int sumPolozh=0;

Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i]=rnd.Next(-9,10);
}

foreach (var item in arr)
{
    System.Console.Write(item + ", ");
}

foreach (var item in arr)
{
    if (item<0)
    {
        sumOtric+=item;
    }
    else sumPolozh+=item;
}
System.Console.WriteLine();
System.Console.WriteLine($"сумма отрицательных чисел = {sumOtric}; " + $"сумма положительных чисел = {sumPolozh}.");