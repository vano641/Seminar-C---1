//Напишите программу которая будет создавать копию заданного массива
//с помощью поэлементного копирования

using System;
using static System.Console;
Clear();

Write("введите размер массива: ");
int N = int.Parse(ReadLine());
//1
int[] array = GetArray(N,1,10);
WriteLine(String.Join(" ",array));
//2
CopyArray(array);
WriteLine(String.Join(" ",array));

//3 Решение преподователя
int[] array2 = CopyArray2(array);
WriteLine(String.Join(" ",array2));

//2 Мое решение
void CopyArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] *= 1;
    }
}


//3 Решение преподователя 
int[] CopyArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i]=inArray[i];
    }
    return result;
}



//1
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
