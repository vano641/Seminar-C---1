// Напишите программу вычисления функции Аккермана с помощью РЕКУРСИИ
// Даны два неотрицательных числа M и N.
// M = 3, n = 2  =>  А(M,N) = 29

using System;
using static System.Console;
Clear();

Write("Введите M: ");
int a = int.Parse(ReadLine());
Write("Введите N: ");
int b = int.Parse(ReadLine());

if(a < 0)
{
    WriteLine($"Число {a} - отрицательное, введите неотрицательное число");
    return;
}
if(b < 0)
{
    WriteLine($"Число {b} - отрицательное, введите неотрицательное число");
    return;
}

WriteLine($"Функция Аккермана - {Akkerman(a,b)}");

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}