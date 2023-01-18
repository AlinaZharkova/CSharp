// Напишите программу, которая выводит случайное число из отрезка [10,99] 
//и показывает наибольшую цифру числа (85->8, 14->4).

int Max(int a, int b) // вводим функцию для сравнения 2 чисел между собой
{
    if (a>b) return a;
    else return b;
}

int a = new Random().Next(10, 100);
System.Console.WriteLine($"Random = {a}");

int firstNum = a / 10; //целочисленное деление на 10
int secondNum = a % 10; //остаток от целочисленного деления на 10

int max= Max(firstNum, secondNum);

System.Console.WriteLine($"Max = {max}");



