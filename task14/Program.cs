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