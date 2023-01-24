// Напишите программу, которая принимает на вход координаты 2 точек и находит расстояние 
//между ними в 3D-пространстве А(3,б,8); В(2,1,-7) -> 15,84
System.Console.WriteLine("Введите координату точки A по оси X: ");
double coordinateAX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату точки A по оси Y: ");
double coordinateAY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату точки A по оси Z: ");
double coordinateAZ = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату точки B по оси X: ");
double coordinateBX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату точки B по оси Y: ");
double coordinateBY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату точки B по оси Z: ");
double coordinateBZ = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(coordinateBX - coordinateAX, 2) + Math.Pow(coordinateBY - coordinateAY,2) + Math.Pow(coordinateBZ - coordinateAZ, 2));
System.Console.WriteLine($"Расстояние между точками A и B в пространстве = " + "{0:0.00}", distance);
