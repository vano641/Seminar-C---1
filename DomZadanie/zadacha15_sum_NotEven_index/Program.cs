//Напишите программу, которая находит сумму элементов с нечетными индексами в 
//одномерном массиве целых чисел и выводит результат на экран.
//18      76      11  
//Сумма нечетных элементов: 76

using System;
using static System.Console;
Clear();

//1
int[] array = GetArray(8, 1, 10);
WriteLine(String.Join("\t", array));
//2
int Even = SumOddElements(array);
WriteLine($"сумма Элементов с НЕ четным индексом = {Even}");


//1
int[] GetArray(int size, int min, int max)// метод формирующий массив
{
    int[]result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

//2 МОЕ РЕШЕНИЕ:
//int SumOddElements(int[] arr)// метод который складывает элементы с нечетным индексом
//{
//   int sumNumberIndex = 0;
   
//   for (int i = 1; i < arr.Length; i++)// начинаю перебор массива с 1ого элемента, а не с 0 (i=1)
//   {
//        sumNumberIndex += arr[i];
//        i++; // дополнительно увеличивая индекс мы "перепрыгиваем" Четные индексы.
//   }
//   return sumNumberIndex;
//}

//2 РЕШЕНИЕ ПРЕПОДОВАТЕЛЯ
int SumOddElements(int[] arr)// метод который складывает элементы с нечетным индексом
{
   int sumNumberIndex = 0;
   
   for (int i = 1; i < arr.Length; i++)// начинаю перебор массива с 1ого элемента, а не с 0 (i=1)
   {
        if(i % 2 == 1) sumNumberIndex += arr[i]; // если i не четное, то увеличим sumNumberIndex на значение 
        //текущего элемента массива arr[i]
        
   }
   return sumNumberIndex;
}
