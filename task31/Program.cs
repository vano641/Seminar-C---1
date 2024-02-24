// Задайте Двумерный массив.
// Найдите сумму элементво находящихся на главной диагоняли
// с индексами (0,0);(1,1);(2,2) итд
// Исходный массив:
// 1    4   7   2
// 5    9   2   3  =>  Sum = 1 + 9 + 2 = 12.
// 8    4   2   4


using System;
using static System.Console;
Clear();

Write("Введите количесво строк: ");
int m = int.Parse(ReadLine());
Write("Введите количесво столбцов: ");
int n = int.Parse(ReadLine());

//1
int[,] array = GetRandomArray(m, n, 1, 10);
//2
PrintArray(array);

WriteLine($"Сумма = {GetSum(array)}");


//1    Метод создающий Случайный Двумерный массив.
int[,] GetRandomArray(int rows, int columns, int min, int max) 
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max+1);
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

//3
int GetSum(int[,] inArray) // т.к Сумма это число, то нам достаточно просто число(int) для метода
{
    int sum = 0;
    //т.к матрица (двумерн.массив) может быть с разным количеством строк и столбцов. 
    //Поэтому необходимо найти минимальное значение между строкой и столбцом
    int length = inArray.GetLength(0); // переменной length присвоим в начале значение количества строк
    if (length > inArray.GetLength(1)) length = inArray.GetLength(1); // если наша длинна Больше количества Столбцов,
    // то присвоим ей именно значение количества столбцов

    for(int i = 0; i < length; i++) // в рамках одного цикла пройдем по нашему массиву.
    // Т.к идем по главной диагонали то не надо вводить вторую переменную
    {
        sum += inArray[i,i]; //условие if нужно дляч того чтобы при обходе алгорим не обращался к несуществующиму элементу
    }
    return sum;
}