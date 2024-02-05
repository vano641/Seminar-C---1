//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элементы, второй и предпоследний...
// Результат запишите в новом массиве.
// [1,2,3,4,5] -> [5,8,3];
// [6,7,3,6] -> [36, 21];

using System;
using static System.Console;
Clear();


//1
Write("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());

int[] outArray = GetResultArray(array);
WriteLine(String.Join(" ", outArray));

//1 вводим массив с клавиатуры
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
//2 метод формирует новый массив
int[] GetResultArray(int[] inArray)
{
    //считаем какая размерность нашего массива ЧЕТНАЯ или НЕ ЧЕТНАЯ
    int size = inArray.Length/2; // переменная size - половина от изначального массива
    if(inArray.Length % 2 == 1) size++; // проверим если длинна не четная, то size+1
    //это позволит нам создать "центральный" элемент в конце массива

    int[] result = new int[size];// новый массив куда будем записывать наши произведения
    
    for(int i = 0; i < inArray.Length / 2; i++) 
// т.к i является началом, то вычитая i из конца постоянно мы получим симметрично обход всего массива
    {
        result[i] = inArray[i] * inArray[inArray.Length - 1 - i];
// входной элемент(первый) * на последний элемент массива (первый элемент массива 0 последний -1  
//и на каждом проходе уменьшаем это на i (-i))
    }
// проверка на четность получненного массива. (центральный элемент массива в случае не четного количества элементов)
    if(inArray.Length % 2 == 1) result[size - 1] = inArray[inArray.Length / 2];
    return result;
}