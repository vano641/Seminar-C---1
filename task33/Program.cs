// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент в выходных данных.
// 1   9   9        0 - 3 раза;  8 - 1 раз;
// 0   2   8    =>  1 - 1 раз;   9 - 3 раза;
// 0   9   0        2 - 1 раз;


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
int[] rowArray = GetRowArray(array);
WriteLine($"{String.Join(" ",rowArray)}");
//4
SortArray(rowArray);
WriteLine(String.Join(" ",rowArray));
WriteLine();
//5
PrintData(rowArray);

//5 Метод Считающий и Печатающий количество каждого элемента
void PrintData(int[] inArray)
{
    //вводим переменную которая смотрит какое значение находится в нашем массиве
    int el = inArray[0];
    int count = 1; // переменная считает сколько раз встречается el в нашем массиве
    // т.к переменная на старте чемуто равна, то count=1
    for (int i = 1; i < inArray.Length; i++) // начинаем с 1ой переменной
    {
        //сравним следующую переменную с текущей
        if (inArray[i]!=el)
        {
            WriteLine($"{el} встречается {count} раз");
            el = inArray[i];
            count = 1;
        }
        else // если значение не изменилось, то мы просто считаем количество одинаковых элементов
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count} раз"); // для того чтобы напечатать последний элемент
}

//4 Метод Сортирующий Одномерный массив
void SortArray(int[] rowArray)
{
    for (int i = 0; i < rowArray.Length; i++)
    {
        for (int j = i + 1; j < rowArray.Length; j++)
        {
            if(rowArray[i] > rowArray[j])
            {
                int k = rowArray[i];
                rowArray[i] = rowArray[j];
                rowArray[j] = k;
            }
        }
    }
}

//3 Метод возвращает Одномерный массив с элементами Двумерного массива.
int[] GetRowArray(int[,] inArray)
{
    //количество элементов в двумерном массиве = Строки * Столбцы => одномерный массив будет с этой длинной
    int[] rowArray = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    // заполним одномерный массив
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            rowArray[index] = inArray[i,j];
            index++;
        }
    }
    return rowArray;
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

