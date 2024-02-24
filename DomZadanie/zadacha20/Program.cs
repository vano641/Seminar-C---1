// Задать массив. Написать программу которая принимает на вход Значение Элемента
// и возвращает информацию о наличии этого элемента в массиве.
// Исходный массив:         Результат:
// 1   4   7   2        17 - элемент не найден
// 5   9   2   3         4 - элемент найден
// 8   4   2   4


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

WriteLine();

//3
Write("Введите элемент: ");
int element = int.Parse(ReadLine());// элемент для поиска

if(FindElement(array, element))
{
    WriteLine($"{element} - Найден");
}
else
{
    WriteLine($"{element} - НЕ найден");
}

//3
bool FindElement(int[,] inArray, int el) // метод ищет Нужный элемент true или false
//inArray массив в котором ищем
//el элемент который будем искать
{
    for (int i = 0; i < inArray.GetLength(0); i++) // можно использовать foreach
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(array[i,j] == el) return true;// если искомый элемент нашелся, 
            //то мы сразу возвращаем true
        }
    }
    return false;// если по окончании обхода элемент не встретился вернем false
}



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
            Write($"{inArray[i,j]} "); 
        }
        WriteLine(); // 
    }
}