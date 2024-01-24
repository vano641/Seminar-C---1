using System;
using static System.Console;
Clear();
// Мое Решение
Write("Введите число N: ");
int N = int.Parse(ReadLine());


for(int i=1; i<=N; i++) 
{
    WriteLine($"{i*i*i} ");
}