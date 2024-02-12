using System;
using static System.Console;
Clear();
Write("Введите размер массива: ");
int n = int.Parse(ReadLine());
int[] array1 = GetArray(n, 1, 10);
WriteLine(String.Join(" ", array1));

int[] array2 = ReverseArray1(array1);
WriteLine(String.Join(" ", array2));

ReverseArray2(array1);
WriteLine(String.Join(" ", array1));

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
//ВАРИАНТ 1. Метод Разворота массива. Метод возвращает новый развернутый массив
int[] ReverseArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];// размер массива такойже как и во входном массиве
    //заполняем новый массив в обратном порядке относительно входного массива
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];//текущему элементу массива присвоим значение
        //с конца входного массива (обратимся к крайнему элементу inArray.Length - 1 - i)
    } 
    return result;
}

//ВАРИАНТ 2. Метод реверса Меняя элементы местами в действующем массиве.
void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = k;
    }
}