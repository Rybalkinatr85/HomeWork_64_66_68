// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();

Write("Введите число M: ");
int m = int.Parse (ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse (ReadLine()!);

WriteLine (SumMN(m - 1, n));

// метод суммы чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    m++;
    res = m + SumMN(m, n);
    return res;
}
