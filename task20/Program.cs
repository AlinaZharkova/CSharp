// Напишите программу, которая принимает на вход координаты 2 точек и находит расстояние 
//между ними в 2D-пространстве А(3,б); В(2,1) -> 5,09
System.Console.WriteLine("Введите координату точки A по оси X: ");
double coordinateAX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату точки A по оси Y: ");
double coordinateAY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату точки B по оси X: ");
double coordinateBX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату точки B по оси Y: ");
double coordinateBY = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(coordinateBX - coordinateAX, 2) + Math.Pow(coordinateBY - coordinateAY,2));
System.Console.WriteLine($"Расстояние между точками A и B на плоскости = " + "{0:0.00}", distance);