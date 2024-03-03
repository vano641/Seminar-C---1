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
// МОЕ РЕШЕНИЕ:
//3
int[] sumarray = StringElSum(array);
WriteLine($"{String.Join(" ",sumarray)}");
WriteLine();
//4
WriteLine($"строка с min суммой Элеиментов - {MinNumber(sumarray)}");

//МОЕ РЕШЕНИЕ:

//4 Метод который находит Наименьший элемент Одномерного массива.
int MinNumber(int[] inArray)
{
    int index = inArray[0];// переменная для сохранения Минимального индекса
    int min = inArray[0]; // переменная для сохранения Значения элемента
    for (int i = 0; i < inArray.Length; i++)
    {
        if(min > inArray[i])
        {
            min = inArray[i];
            index = i;
        }
    }
    return index;
}

//3 Метод возвращает Одномерный массив состоящий из Сумм элементов каждой строки.
int[] StringElSum(int[,] inArray)
{
    int[] elSum = new int[inArray.GetLength(0)];
    // заполним одномерный массив
    int index = 0;
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i,j];
            elSum[index] = sum; 
        }
        sum = 0;
        index++;
    }
    return elSum;
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
