// Задайте двумерный массив размера m на n
// каждый элемент в массиве находится по формуле: Amn = m + n.
// выведите полученный массив на экран
// m = 3; n = 4
//  0   1   2   3
//  1   2   3   4
//  2   3   4   5

using System;
using static System.Console;
Clear();

Write("Введите количесво строк: ");
int m = int.Parse(ReadLine());
Write("Введите количесво столбцов: ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n);
PrintArray(array);


// Метод возвращающий ДВУМЕРНЫЙ массив
int[,] GetArray(int rows, int columns) 
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = i+j; //каждый элемент в массиве находится по формуле: Amn = m + n.
        }
    }
    return result;
}


// Метод который Печатает ДВУМЕРНЫЙ массив. (String.Join не подойдет)
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} "); //выводим элементы в одну строку
        }
        WriteLine(); // переходим на новую строку
    }
}
