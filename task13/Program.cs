// Написать программу, которая выводит на экран третью цифру заданного числа или сообщает, 
//что третьей цифры нет (645-5, 78-нет, 32679-6)

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

// Функция принимает число, введенное пользователем, количество символов, и выводит третью цифру числа. 
//Если 3 цифры нет, сообщает и выводит 0.
int MakeArray(int a, int b)
{
int result = -1;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет,  ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10; // откидываем последнюю цифру до тех пор, пока не станет i=3
    }
return result;
}

// второй вариант решения задачи (не работает для отрицательных чисел и чисел в котором цифр меньше 3)
// string? str = System.Console.WriteLine();//переводим число в строку
// if (str==null) return;
// System.Console.WriteLine(str[2]);// возвращает 2 по индексу значение строки