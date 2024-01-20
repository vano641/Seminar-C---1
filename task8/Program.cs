using System;
using static System.Console; 
Clear();

Write("Введите А: ");
int A = int.Parse(ReadLine());
// Мое решение (проверяет условия последовательно)
if(A % 7 == 0)
{
    WriteLine("число А кратно 7");
}
else
{
    WriteLine($"не кратно 7");
}
if(A % 23 == 0)
{
    WriteLine("число А кратно 23");
}
else
{
    WriteLine($"не кратно 23");
}

//Решение Преподавателя

if((A % 7 == 0)&&(A % 23 == 0)) // Одновременная проверка 2ух условий через операто &&
{
    WriteLine($"{A} -> Yes ");
}
else
{
    WriteLine($"{A} -> No ");
}