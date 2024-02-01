//Замена элементов массива. Положительные элементы поменять на отрицательные и наоборот
// [-4,-8,8,2]=>[4,8,-8,-2]

using System;
using static System.Console;
Clear();

//1
int[] array = GetArray(8, -10, 10);
WriteLine(String.Join(",",array)); // выводим наш первоначальный массив
//2
InverseArray(array);
WriteLine(String.Join(",",array)); // выводим измененный массив

//1
int[] GetArray(int size, int min, int max) // метод создающий массив в указанном диапазоне
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1); // max+1 т.к нумерация в массиве с 0 и песледнее число не попадает
    }
    return result;
}
//2
void InverseArray(int[] inArray) // метод который изменяет массив
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i]*=-1; // каждый элемент массива умножим на -1 => положительные станут отрицательными и наоборот
    }
}