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
int result = 0;
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