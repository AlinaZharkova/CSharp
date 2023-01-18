// Написать программу, которая принимает на вход 2 числа и проверяет является ли первое число кратным второму.
// Если число 1 не кратно 2, то вывести остаток от деления (34, 5 -> не кратно, остаток 4.   16, 4 -> кратно)
int InputNumber() // вводим функцию для ввода целого числа с клавиатуры
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNum = InputNumber();
int secondNum = InputNumber();

if (firstNum % secondNum == 0)
{
    System.Console.WriteLine("кратно");
}

else
{
    System.Console.WriteLine("не кратно, остаток " + firstNum % secondNum);
}