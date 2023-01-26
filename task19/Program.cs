//Напишите программу, которая на вход принимает пятизначное число и проверяет является ли 
//оно палиндромом.

System.Console.WriteLine("введите пятизначное число: ");

string? number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
    Console.WriteLine($"Число {number} является палиндромом");
    }

    else 
    {
    Console.WriteLine($"Число {number} - не палиндром");
    }
}

    if (number!.Length == 5) 
    {
        CheckNumber(number);
    }
    else 
    
        Console.WriteLine($"Введите Пятизначное число!");
