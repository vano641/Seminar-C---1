using System;
using static System.Console;
Clear();
// Мое Решение
Write("Введите число N: ");
int N = int.Parse(ReadLine());
int count = 1;
int result = 0; // математический метод
int result2 = 0; // метод встроенных функций

while(count <= N)
{
    result = count * count;
    result2 = Convert.ToInt32(Math.Pow(count,2));
    WriteLine($"Таблица квадратов от 1 до {N} => {result} ; {result2}");
    count++;
}
// Решение преподователя
for(int i=1; i<=N; i++) // в цикле for вводим переменную i=1; которая i<=N и i++ увеличивается на+1
{
    Write($"{i*i} ");
}