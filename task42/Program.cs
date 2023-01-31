// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int InputNumber()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = InputNumber();
string n = string.Empty;

while (a >= 1)
{
    n = a % 2 + n;
    a = a / 2;
}
Console.WriteLine(n);