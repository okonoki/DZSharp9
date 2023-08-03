﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersRec(int n)
{
    if (n == 0) return "";
    else return $"{n}, " + NumbersRec(n - 1);
}

Console.WriteLine(NumbersRec(5));