// РЕКУРСИВНЫЙ МЕТОД. 
// Задайте значения M и N. 
// Вывести все натуральные числа в промежутке от M до N
// M = 4
// N = 8 => 4,5,6,7,8

using System;
using static System.Console;
Clear();

Write("введите M: ");
int m = int.Parse(ReadLine());

Write("введите N: ");
int n = int.Parse(ReadLine());
WriteLine(PrintNumber(m,n));

string PrintNumber(int start, int end)
{
    if(start == end) return start.ToString();
    
    return(start + " " + PrintNumber(start + 1, end));
    
}
