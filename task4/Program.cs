﻿// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число ");
string InpN = Console.ReadLine();
double N = Convert.ToDouble(InpN);

int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
        i++;
}

