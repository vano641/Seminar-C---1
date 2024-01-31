// Программа которая принимает на вход число N и выдает сумму чисел от 1 до N
// 7 -> 28; 4 -> 10; 8 - 36.

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(ReadLine());
int summa = GetSumNumbers(N);
WriteLine($"Сумма = {summa}");


int GetSumNumbers(int number) // в метод передаем число number, метод возвращает сумму
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    {
        sum += i; // к сумме прибавляем значение i
    }
    return sum;
}