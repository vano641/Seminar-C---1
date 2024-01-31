using System;
using static System.Console; 
Clear();

WriteLine($"{String.Join(",",GetBunaryArray(8))}" );// метод  String.Join позволяет вывести элементы массива 
//любой размерности с любым разделителем, в качестве разделителя "," в качестве массива GetBunaryArray(8)

int[] GetBunaryArray(int size) // метод создает массив целочисленных значений
// int size универсальный метод чтобы формировать массив произвольной длинны
{
    int[] result = new int[size];//создаем возвращаемый массив result, [size] - размер массива
    for(int i = 0; i < size; i++) // т.к индексы в массиве нумеруются с 0 то i < size.
    // если поставить i <=size то последний элемент массива будет вне цикла
    {
        result[i] = new Random().Next(0,2);// обращаемя к элементу[i] массива result и создаем ее случайно
        // min 0 max на 1 больше => 2
    }
    return result;
}