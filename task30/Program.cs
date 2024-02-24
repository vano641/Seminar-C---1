// Задайте двумерный массив.
// найдите элементы, у который оба индекса четные
// и замените эти элементы на их квадраты
// Исходный массив:     Результат:
// 1    4   7   2       1   4   7   2
// 5    9   2   3       5   9   2   3
// 8    4  (2)  4       8   4  (4)  4

using System;
using static System.Console;
Clear();

Write("Введите количесво строк: ");
int m = int.Parse(ReadLine());
Write("Введите количесво столбцов: ");
int n = int.Parse(ReadLine());

//МОЕ РЕШЕНИЕ

//1
int[,] array = GetArray(m, n);
//2
PrintArray(array);

WriteLine();

//3
int[,] array2 = GetResult(m, n);
//2
PrintArray(array2);

// РЕШЕНИЕ ПРЕПОДОВАТЕЛЯ:

// Массив формируется автоматически Случайным образом, 
// поэтому при изменении массива мы начинаем перебор сразу с 2ого индекса исключая 0 
WriteLine();

int[,] array3 = GetRandomArray(m, n, 1, 10);
PrintArray(array3);

WriteLine();

ChangeArray(array3);
PrintArray(array3);

// МОЕ РЕШЕНИЕ:

//1   Метод возвращающий ДВУМЕРНЫЙ массив
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

//2   Метод который Печатает ДВУМЕРНЫЙ массив.
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

//3 Метод возводящий четные индексы в квадрат.
int[,] GetResult(int rows, int columns)
{
    int[,] result1 = new int[rows, columns];
    for (int i = 0; i < result1.GetLength(0); i++) // перебераем с 0 индекса т.к формируем массив i+j
    {
        for (int j = 0; j < result1.GetLength(1); j++)
        {
            result1[i,j] = i+j;
            if ((i % 2 == 0)&&(j % 2 == 0))
            {
                result1[i,j] = result1[i,j] * result1[i,j];
            }
        }   
    }
    return result1;
}



// РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ:

//5   Метод изменяющий первоночальный двумерный массив
void ChangeArray(int[,] inArray)
{
    for (int i = 2; i < inArray.GetLength(0); i++) // перебераем со 2ого индекса чтобы исключить 0
    {
        for (int j = 2; j < inArray.GetLength(1); j++)
        {
            if((i % 2 == 0)&&(j % 2 == 0)) inArray[i,j] *= inArray[i,j];
        }
    }
}

//6    Метод создающий Случайный Двумерный массив.
int[,] GetRandomArray(int rows, int columns, int min, int max) 
{
    int[,] result = new int[rows, columns]; //результирующий массив входные параметры [строки и столбцы]

    for (int i = 0; i < result.GetLength(0); i++) // с помощью метода GetLength можно обратиться к размерности массива
    //т.к в методе new int мы указали 2 переменные, rows стоит на 0 позиции => чтобы получить максимальное количество строк
    // в методе GetLength указываем (0).
    {
        for (int j = 0; j < result.GetLength(1); j++) // тоже самое делаем со столбцами
        {
            result[i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}