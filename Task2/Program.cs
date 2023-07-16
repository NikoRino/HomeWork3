﻿// // Напишите программу, которая принимает на вход координаты двух точек и находит 
// // расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

void Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double distans = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    Console.WriteLine($"Расстояние межэду двух точек: {distans}!");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = GetInput("Введите координату Х точки А: ");
int ay = GetInput("Введите координату Y точки А: ");
int az = GetInput("Введите координату Z точки A: ");
int by = GetInput("Введите координату X точки B: ");
int bx = GetInput("Введите координату Y точки B: ");
int bz = GetInput("Введите координату Z точки B: ");

Distance(ax, ay, az, bx, by, bz);