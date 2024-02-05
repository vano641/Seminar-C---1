//Напишите программу для работы с массивом вещественных чисел.
//Реализуйте класс ArrayOperations, который содержит следующие статические методы:

//FindMax(double[] array): Метод принимает на вход массив вещественных чисел array 
//и возвращает максимальное число из массива.

//FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и 
//возвращает минимальное число из массива.

//CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и
//возвращает разницу между максимальным и минимальным числами в массиве.



using System;
using static System.Console;
Clear();

//1
int[] array = GetArray(8, 1, 10);
WriteLine(String.Join("\t", array));

int min = array[0];
int max = array[0];

foreach (int item in array)
{
    if(min > item) min = item;
    if(max < item) max = item;
}

WriteLine($"Минимальный элемент - {min}, Максимальный элемент - {max}");
WriteLine($"Разница = {max-min}");


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









