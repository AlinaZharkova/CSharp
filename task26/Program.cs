// Напишите программу, которая принимает на вход число и выдает количество цифр в числе (456->3, 9087654->7)
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int count = 0; //количество цифр в числе

while (A > 0)
{
    A = A/10;
    count++;
}
Console.WriteLine($"Количество цифр в числе = {count}");
