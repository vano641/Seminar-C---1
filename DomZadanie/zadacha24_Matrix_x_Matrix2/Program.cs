// Задайте ДВЕ матрицы.
// Напишите программу, которая будет находить ПРОИЗВЕДЕНИЕ двух матриц
//  Массив А:        Массив В:       Результат:
// 6   0   2        0   0   3       16  4   18
// 0   4   8        5   0   4   =>  84  16  16
// 0   7   9        8   2   0       107 18  28

using System;
using static System.Console;
Clear();

Write("Введите количество строк: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine());

//1
int[,] array = GetRandomArray(m, n, 0, 5);
int[,] array2 = GetRandomArray(m, n, 0, 5);
//2
PrintArray(array);
WriteLine();
PrintArray(array2);
WriteLine();
// умножать матрицы можно только в том случае когда
// количество Столбцов первой матрицы = количеству Строк второй матрицы
if(array.GetLength(1)!=array2.GetLength(0))
{
    WriteLine("Такие матрицы умножать нельзя!");
    return;
}

int[,] result = GetResult(array, array2);
PrintArray(result);


//3 Метод вычисляющий Произведение двух матриц
int[,] GetResult(int[,] inArray1, int[,] inArray2)
{
    int[,] result = new int[inArray1.GetLength(0), inArray2.GetLength(1)];


    for (int i = 0; i < inArray1.GetLength(0); i++)// Строка inArray1
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)// Столбцы inArray2
        {
            for (int k = 0; k < inArray1.GetLength(1); k++) // Столбцы inArray1
            {
                result[i,j] += inArray1[i,k] * inArray2[k,j];
                // inArray1[i,k] - строка и столбец Первого массива
                // inArray2[k,j] - k - номер столбца Первого массива
                //                 j - номер столбца Второго массива
                // Переменная k - общая для Двух Массивов(в inArray1 она на позиции Столбца
                //                                        в inArray2 она на позиции Строки) 
            }
        }
    }
    return result;
}


//1 Метод создающий Случайный Двумерный массив
int[,] GetRandomArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

//2 Метод Печатающий Двумерный массив
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
