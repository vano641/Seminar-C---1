//Напишите программу, которая подсчитывает количество четных элементов в массиве целых
// положительных трехзначных чисел и выводит результат на экран. 

using System;
using static System.Console;
Clear();

//1
int[] array = GetArray(9, 100, 999);
WriteLine(String.Join("\t", array));

int Even = CountEvenElements(array);
WriteLine($"количество четных элементов = {Even}");


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

//2
int CountEvenElements(int[] arr) // метод проверяющий на четность
{
    int count = 0;
    foreach (int item in arr)
    {
        if(item % 2 == 0) count++;
    }
    return count;
}



