﻿// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
double Cub;
while (i<=N)
{
    //Math.Pow (i,3)
    Cub =(i*i*i);
    Console.WriteLine($"Число \t|{i}| Куб |{Cub}|");
    i++;
}