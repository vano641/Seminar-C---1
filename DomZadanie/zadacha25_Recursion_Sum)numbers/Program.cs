// Задайте значения M и N. Напишите программу которая найдет сумму натуральных
// элементов в промежутке от M до N.
// M = 1, N = 15  => 120
// M = 4, N = 8 => 30

using System;
using static System.Console;
Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());
WriteLine($"Сумма натуральных элементов от {m} до {n} = {Sum(m,n)}");

// Метод который находит сумму натуральных элементов в промежутке от M до N
int Sum(int m, int n)
{
    if(m == n) return m;
    return(m + Sum(m + 1, n));
}