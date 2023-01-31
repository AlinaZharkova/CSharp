// Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами
// такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 2 других сторон.

int InputNumber()
{
    Console.Write("Введите длину стороны треугольника: ");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = InputNumber();
int b = InputNumber();
int c = InputNumber();

if ((a+b>c)&&(b+c>a)&&(c+a>b))
{
    Console.WriteLine("Треугольник получился!");
}
else Console.WriteLine("Не треугольник.");
