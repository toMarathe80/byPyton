﻿// Семинар 3, Задача 21
// Найти по 2-м точкам расстояние между ними в 3D пространстве, нп
// A (3,6,8); B (2,1,-7), -> 15.84 или A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"d= {d:f2}");