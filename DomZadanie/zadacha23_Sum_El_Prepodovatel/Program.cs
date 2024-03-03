// Задайте прямоугольный Двумерный массив.
// Напишите программу которая будет находить СТРОКУ с НАИМЕНЬШЕЙ суммой элементов
// Исходный массив:
// 1   4   7   2
// 5   9   2   3   =>   1 - Строка
// 8   4   2   4
// 5   2   6   7

using System;
using static System.Console;
Clear();

Write("Введите количество строк: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine());

//1
int[,] array = GetRandomArray(m, n, 0, 5);
//2
PrintArray(array);
WriteLine();

//3
WriteLine($"Строка с Наименьшей суммой элементов - {GetNumberRow(array)}");

// Метод возвращает Номер строки в которой Наименьшая сумма элементов
int GetNumberRow(int[,] inArray)
{
    int row = 0;// строка с минимальной суммой по умолчанию (нулевая по индексу или верхняя)
    int sum = 0;
    // цикл вычисляет сумму верхней строки(нулевой)
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        sum += inArray[0,i]; // работаем только с верхней строкой
    }
    // далее с помощью двух циклов пройдемся по остальным строкам
    for (int i = 1; i < inArray.GetLength(0); i++) // начинаем уже с 1ой Строки
    {
        int minSum = 0; // для каждой из последующих строк введем свою переменную
        
        for(int j = 0; j < inArray.GetLength(1); j++) // цикл идет по Столбцам
        {
            minSum += inArray[i,j]; // вычислим сумму элементов в этой строке
        }
        // проверить условие: если сумма первой(нулевой) строки больше текущей
        if(sum > minSum)
        {
            sum = minSum;
            row = i;
        }
    }
    return row;
}






//1 Метод создающий Случайный Двумерный массив
int[,] GetRandomArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

//2 Метод Печатающий Двумерный массив
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
