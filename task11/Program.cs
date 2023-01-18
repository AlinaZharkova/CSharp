// Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа (456->46)
Random num = new Random();
int a = num.Next(100, 1000);
System.Console.WriteLine($"Случайное трехзначное число {a}");
int firstNum = a / 100;
int thirdNum = a % 10;
a = firstNum * 10 + thirdNum;
System.Console.WriteLine($"Двузначное число {a}");
