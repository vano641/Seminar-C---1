//Ввести с клавиатуры N чисел.
//Посчитать сколько чисел больше 0 ввёл пользователь
//0, 7, 8, -2, -2 => 2
//1, -7, 567, 89, 223 => 3

using System;
using static System.Console;
Clear();


//1
Write("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine(String.Join(" ", array));

//2
int PCount = PositivCount(array);
WriteLine($"Количество элементов > 0 = {PCount}");


//1
int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int PositivCount(int[] inArray)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if(item > 0)
        {
            count++;
        }   
    }
    return count;
}