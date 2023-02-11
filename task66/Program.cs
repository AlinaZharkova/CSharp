//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int temp = M;

if (M > N) 
{
  M = N; 
  N = temp;
}

PrintSum(M, N, temp=0);

void PrintSum(int M, int N, int sum)
{
  sum+= N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов в промежутке от M до N = {sum} ");
    return;
  }
  PrintSum(M, N - 1, sum);
}
