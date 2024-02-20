// ДВУМЕНРНЫЕ МАССИВЫ
// Задайте двумерный массив размером m*n, запосленный случайными целыми числами
// m = 3 ; n = 4.
// 1   4   8   19
// 5  -2   33  -2
// 77  3   8   1 


using System;
using static System.Console;
Clear();

Write("Введите размер массива через пробел: ");
string[] nums = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), -10, 10);
PrintArray(array);




// Метод возвращающий ДВУМЕРНЫЙ массив
int[,] GetArray(int rows, int columns, int min, int max) 
// [,]- двумерный массив
// rows - строки ; columns - столбцы;
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
