// Написать программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.
// (14 - нет, 46 - нет, 161 - да)
int InputNumber() // вводим функцию для ввода целого числа с клавиатуры
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num = InputNumber();

if ((num % 7 == 0) && (num % 23 == 0))
{
    System.Console.WriteLine($"число {num} кратно 7 и 23 одновременно");
}

else
{
    System.Console.WriteLine($"число {num} НЕ кратно 7 и 23 одновременно");
}