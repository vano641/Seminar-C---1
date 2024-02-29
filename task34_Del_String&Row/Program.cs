// Из Двумерного массива целых чисел удалить Строку и Столбец,
// на пересечении которых расположен ПЕРВЫЙ найденный МИНИМАЛЬНЫЙ элемент.
// Исходный массив:         Результат:
// (1)  4   7   2           
//  5   9   2   3     =>    9   2   3
//  8   4   2   4           4   2   4
//  5   2   6   7           2   6   7


using System;
using static System.Console;
Clear();

Write("Введите количество строк: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine());

//1
int[,] array = GetRandomArray(m, n, 0, 5);
//2
PrintArray(array);
WriteLine();
//3
WriteLine($"Минимальный элемент в позиции - {String.Join(";",GetMinIndex(array))}");
WriteLine();
//4

PrintArray(GetResultArray(array, GetMinIndex(array)));


//4 Метод который возвращает Двумерный массив из которого будут исключены Строки и Столбец Минимального элемента
int[,] GetResultArray(int[,] inArray, int[] index) // параметры Двумерный массив и Координаты Строки и Столбца
{
    // результирующий массив длинной меньше на -1 строку и на -1 столбец
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0; // переменная считает Строки
    int column = 0; // переменная считает Столбцы

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        // при проходе по Строке будем искать строку которую нужно Удалить
        if(i==index[0]) continue; // тогда необходимо перейти сразу к следующему шагу
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            // при проходе по Столбцу будем искать Столбец который нужно исключить
            if(j==index[1]) continue;
            result[row, column] = inArray[i, j]; // если условие не выполняется (т.е мы заполняем массив нужными нам строками и столбцами)
            column++;
        }
        row++;
        column = 0; // когда обошли одну строку, нужно обнулить значение столбца
    }
    return result;
}


//3 Метод который будет Возвращать индексы минимального элемента ( в виде Одномерного массива)
int[] GetMinIndex(int[,] inArray)
{
    int[] result = new int[]{0,0}; // Выходной массив(по умолчанию считаем, что элемент с индексами 0,0 является минимальным)
    int min = inArray[0,0];// для поиска минимального элемента вводим доп.переменную
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(min > inArray[i,j])// если минимальный элемент больше текущего
            {
                min = inArray[i,j]; // тогда min становится текущее значени
                result[0] = i; // в резкльтирующий массив помещаем текущие индекся (0вой элемент - строка)
                result[1] = j; // 1ый элемент - столбец
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