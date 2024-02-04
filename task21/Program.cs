// Задайте одномерный массив из 123 случайных чисел. Найдите количество
//элементов массива значения которых лежат в отрезке [10;99]
// [5,18,123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,14] -> 5

using System;
using static System.Console;
Clear();

// МОЕ РЕШЕНИЕ
//1
int[] array = GetArray(10, 0, 123);
WriteLine(String.Join(",", array));// выводим на экран массив
//WriteLine(" ");// пустая строка

//int Count = 0;// переменная которая считает Элементы входящие в отрезок

//foreach (int item in array)
//    {
//        if((item > 9)&&(item < 100))
//        Count++;
//    }
//WriteLine($"-> {Count}");

//2
int countElements = GetCountElements(array,10,99);
WriteLine($"Количество элементов в отрезке [10;99] = {countElements}");


// РЕШЕНИЕ ПРЕПОДОВАТЕЛЯ
//2
int GetCountElements(int[] inArray, int leftRange, int rightRange)
// метод который считает элементы в отрезке [10,99]
{
    int count = 0;
    foreach(int item in inArray)
    {
        if(item >= leftRange && item <= rightRange)
        {
            count++;
        }
    }
    return count;
}


//1 
int[] GetArray(int size, int min, int max)// метод формирующий массив
{
    int[]result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}


