﻿// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);
Console.Clear();
Console.WriteLine("Введите координату X для точки a");
int Xa = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки a");
int Ya = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату X для точки b");
int Xb = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки b");
int Yb = int.Parse (Console.ReadLine()!);
double s = Math.Sqrt(Math.Pow((Xa-Xb),2)+Math.Pow((Ya-Yb),2));
Console.WriteLine(s);

