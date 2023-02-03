﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы, отделяя их между собой запятыми: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse); //ф-ция, которая преобразовывает каждый элемент (строки->массива) в Int.
System.Console.WriteLine("Ваш массив: ");
System.Console.Write( "{" + string.Join(",", array)+ "}"); //из массива формируем строку при помощи сепаратора.
int count = array.Count(x => x > 0); //метод, принимающий функцию (которая возвращает x>0) в качестве параметра.
System.Console.WriteLine();
Console.WriteLine($"Количество элементов больше нуля: {count}");
