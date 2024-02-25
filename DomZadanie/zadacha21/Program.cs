// Задайте Двумерный массив из Целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Исходный массив:         Результат:
// 1   4   7   2
// 5   9   2   3        =>  4,6; 5,6; 3,6; 3
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

//3
WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ",GetSumColumns(array))}");


//3 Метод вычисляющий Среднее арифметическое каждого из столбцов.
// тип возвращаемых данных double
// возвращаемые значения будут в виде массива из элементов(Ср.Арифм каждого из столбцов)
double[] GetSumColumns(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];//сформируем результирующий массив
    // размер массива будет равен количеству столбцов в нашем Входном массиве(inArray).
    for (int i = 0; i < inArray.GetLength(1); i++)// вычислим сумму для каждого столбца.
    //Для этого в начале во внешнем цикле укажем в качестве параметра Обход по столбцам (inArray.GetLength(1))
    {
        double sum = 0;//введем переенную которая будет вычислять сумму
        for (int j = 0; j < inArray.GetLength(0); j++) // обходим массив по строкам
        {
            sum += inArray[j,i]; //вычислим сумму элементов каждого столбца
        }
        //после вычисления суммы передадим в наш Результирующий массив данные о Ср.Арифм
        result[i] = Math.Round(sum / inArray.GetLength(0),1); // элемент в Результ. массиве равен Ср.Арифм в столбце.
        // для этого Сумму элементов в столбце / на количество строк
        //Math.Round позволяет округлять значение переменных с точность как нам необходимо
        // в нашем случае до 1ого знака после запятой
    }
    return result;

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