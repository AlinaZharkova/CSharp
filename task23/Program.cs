//Написать программу, которая на вход принимает число (N), а на выходе выдвет таблицу кубов чисел от 1 до N. (5-> 1,8,27,64,125)
System.Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
double cube = 1; 
    for (int i =1; i<= n; i++)
{

    cube = Math.Pow(i, 3);
    System.Console.Write($" {cube} " + ".");
} 


