//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int funcAkkerman = Akk(M, N);

Console.Write($"Функция Аккермана = {funcAkkerman} ");

int Akk(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Akk(M - 1, 1);
  else return Akk(M - 1, Akk(M, N - 1));
}
