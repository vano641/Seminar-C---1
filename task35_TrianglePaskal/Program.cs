// Показать треугольник Паскаля
// Сделать вывод в виде равнобедренного треугольника
//      1
//     1 1
//    1 2 1
//   1 3 3 1
//  1 4 6 4 1
//1 5 10 10 5 1

using System;
using static System.Console;
Clear();

Write("Введите количество строк: ");
int rows = int.Parse(ReadLine());

PrintTriangle(rows);

//2 Метод выводящий треугольник
void PrintTriangle(int n) // входной параметр - количество строк в нашем треугольнике
{
    for (int i = 0; i < n; i++)
    {
        // в первом цикле выводим Пробелы
        for (int c = 0; c <= (n - i); c++)
        {
            Write("  ");
        }
        //Вторым циклом вычисляем число которое расположено в рамках Треугольника Паскаля
        for (int k = 0; k <= i; k++)
        {
            Write("   ");
            Write(factorial(i)/(factorial(k)*factorial(i-k)));
        }
        WriteLine();
    }
}

//1 Метод вычисляющий Факториал числа
int factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
