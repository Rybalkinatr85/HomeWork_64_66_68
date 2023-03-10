// 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его чисел

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int n = int.Parse(ReadLine()!);

WriteLine ($"{n} -> Сумма цифр {PrintSumNumbers (n)}");

int sum = 0;
while (n>0)
{
sum+=n%10;
n/=10;
}
WriteLine ($"{sum}");

int PrintSumNumbers (int n)
{
    if (n == 0)
    return 0;
    return (n % 10 + PrintSumNumbers(n / 10));
}