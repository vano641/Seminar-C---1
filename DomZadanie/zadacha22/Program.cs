// Задайте Двумерный массив. Напишите программу, 
//которая упорядочит по УБЫВАНИЮ элементы каждой СТРОКИ двумерного массива
// Исходный массив:         Результат:
// 1   4   7   2           7   4   2   1
// 5   9   2   3    =>     9   5   3   2
// 8   4   2   4           8   4   4   2

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
SortArray(array);
PrintArray(array);

//3 Сортировка Строк в Двумерном массиве
void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if(inArray[i,k] > inArray[i,j])
                {
                    int temp = inArray[i,j];
                    inArray[i,j] = inArray[i,k];
                    inArray[i,k] = temp;
                }
            }
        }   
    }
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


