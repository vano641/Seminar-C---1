// напите программу которая принимает на вход число и 
//выдает количество цифр в числе 456=>3; 78=>2; 89126=>5


using System;
using static System.Console; 
Clear();

Write("Введите число : ");
//int num = int.Parse(ReadLine());
//int countNums = GetCountNumbers(num);
WriteLine($"Количество цифр в числе = {GetCountNumbers(int.Parse(ReadLine()))}");
// можно записать в одну строку не создавая дополнительных переменных
// сразу считывая с клавиатуры и передовая в ниш метод

int GetCountNumbers(int number)
{
    int count = 0;// переменная которая запоминает Разряды числа
    while(number > 0) // пока наше число будет >0 в результате Целочисленного деления
    {
        count++; // если число > 0 то в нем есть хотябы 1 разряд
        number/=10;
    }
    return count;
}
