//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//Внутри класса Answer напишите метод CreateRandomMatrix,
//который принимал бы числа m и n (размерность массива), а также minLimitRandom и maxLimitRandom,
//которые указывают на минимальную и максимальную границы случайных чисел.

//акже, задайте метод PrintArray, который выводил бы массив на экран.
//Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j]
//с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. 
//Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

using System;
using static System.Console;
Clear();

Write("Введите количесво строк: ");
int m = int.Parse(ReadLine());
Write("Введите количесво столбцов: ");
int n = int.Parse(ReadLine());

//1
double[,] array = CreateRandomMatrix(m, n, -10, 10);
PrintArray(array);



//1    Метод создающий Случайный Двумерный массив.
double[,] CreateRandomMatrix(int rows, int columns, int minLimitRandom, int maxLimitRandom) 
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            //Базово - метод формирования Целых Чисел. В начале наш диапазон мы увеличим на *10,
            // а потом разделим обратно на эту /10 чтобы получить дробную часть.
            // важно привести наш тип  к (double) чтобы сохранить дробную часть.
            result[i,j] = ((double)(new Random().Next(minLimitRandom * 10, (maxLimitRandom+1) * 10))) / 10;
            //
        }
    }
    return result;
}


//2   Метод который Печатает ДВУМЕРНЫЙ массив.
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]}  ");
        }
        WriteLine(); 
    }
}