// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 1ую и Последнюю строку массива
// Исходный массив:             Результат:
// 1   4   7   2            8   4   2   4
// 5   9   2   3    =>      5   9   2   3
// 8   4   2   4            1   4   7   2

using System;
using static System.Console;
Clear();

Write("Введите количество строк: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine());
// не каждую матрицу можно изменить.
// количество строк должно = количеству столбцов
if(m!=n) // если m не равно n то такую матрицу изменить нельзя
{
    WriteLine("Такой массив изменить нельзя!");
    return;
}
//1
int[,] array = GetRandomArray(m, n, 1, 9);
//2
PrintArray(array);

//3
int[,] array2 = GetResultArray(array);
WriteLine();
//2
PrintArray(array2);


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

//3 Метод который меняет местами Первую и Последнюю строки

int[,] GetResultArray(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(0)]; // т.к массив "квадратный, 
    //то достаточно использовать одну из сторон нашего входного массива

// Создадим новый массив
// Строки будут содержать Элементы которые находятся в Столбцах входного массива
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[j,i] = inArray[i,j];
        }
    }
    return result;
}