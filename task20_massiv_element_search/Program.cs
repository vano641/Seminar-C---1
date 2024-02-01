
using System;
using static System.Console;
Clear();

//1
WriteLine("Введите через пробел массив: ");
int[] array = GetArrayFromString(ReadLine()); // массив заполняем с консоли

Write("Введите элемент: ");
int element = int.Parse(ReadLine());// элемент для поиска

//2
if(FindElement(array,element))
{
    WriteLine("yes");
}
else
{
    WriteLine("no");
}

//1
int[] GetArrayFromString(string stringArray) // вводим массив из строки 
//(можно просить отдельно ввести каждый элемент) или (ввести строку и разбить на элементы)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries); // оператор разбивает Строку на подстроки и возвращает массив строк
//string[] numS - массив строк
//stringArray.Split - позволяет по указанному сипоратору 'пробел' разбивать нашу строку.
//StringSplitOptions.RemoveEmptyEntries - убирает из получившегося массива строк пустые элементы
    int[] result = new int[numS.Length]; 
// result - это числовой массив который получается считываем элементов из numS(массива строк)
    for(int i = 0 ; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]); 
    }
    return result;
}

//2
bool FindElement(int[] inArray, int el) // метод ищет Нужный элемент true или false
//inArray массив в котором ищем
//el элемент который будем искать
{
    foreach (int item in inArray)
    {
        if(item == el) return true;
    }
    return false;
}


