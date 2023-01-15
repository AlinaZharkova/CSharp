Console.Clear();
Console.WriteLine("первое число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("второе число");
int b = Convert.ToInt32 (Console.ReadLine());
if (a==b*b) 
{    
Console.WriteLine($"{a} квадрат {b}");
}
else
{
System.Console.WriteLine("Не квадрат числа!");
}

