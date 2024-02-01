// Задайте массив из 12 случайных элементов из промежутка [-9,9].
//Найдите сумму отрицательных и положительных элементов массива.
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] => -20;29

using System;
using static System.Console;
Clear();

int[] array = GetArray(12, -9, 9);
WriteLine(String.Join(",",array)); // выводим наш массив
int PositivSum = 0;
int NegativSum = 0;
// способ перебора массива, этот оператор позволяет только опросить массив,
// а изменять элементы нельзя.

//foreach (var item in collection) так выводится по умолчанию

//после in "collection" - сюда передаем параметр который хотим опросить то есть array
//item - это переменная которая на каждом шаге будет переменной массива.
//если массив целочисленный, то int item
foreach (int item in array)
{
    if(item > 0)
    {
        PositivSum += item;
    }
    else
    {
        NegativSum += item;
    }
}
WriteLine($"Сумма положительных элементов = {PositivSum}, сумма отрицательных элементов = {NegativSum}");

int[] GetArray(int size, int min, int max) // метод создающий массив в указанном диапазоне
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1); // max+1 т.к нумерация в массиве с 0 и песледнее число не попадает
    }
    return result;
}