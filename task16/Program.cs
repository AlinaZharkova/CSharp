// Написать программу, которая принимает на вход 2 числа и проверяет является ли одно число квадратом второго.
//  (25,5 -> да, 4,16 -> да, -3,9 -> да,  7,4 -> нет)
int InputNumber() // вводим функцию для ввода целого числа с клавиатуры
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNum = InputNumber();
int secondNum = InputNumber();

if ((firstNum * firstNum == secondNum) || (secondNum * secondNum == firstNum))
{
    System.Console.WriteLine("одно число является квадратом другого");
}

else
{
    System.Console.WriteLine("нет");
}
