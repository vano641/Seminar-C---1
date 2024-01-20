using System;
using static System.Console; 
Clear();

Write("Введите число : ");
int number = int.Parse(Console.ReadLine());

if(number < 100) 
{
    WriteLine($"{number} -число не трехзначное, третьей цифры нет");
    return; // алгоритм дальше не работате т.к не соблюдено условие
    }
else
{   
    if((number > 99)&&(999 > number))
    {
        int a1 = number % 10;
         WriteLine($"{number} -> {a1}");
    }
    if((number > 999)&&(10000 > number))
    {
        int a2 = number % 100;
        int a3 = a2 / 10;
         WriteLine($"{number} -> {a3}");
    }
     if((number > 9999)&&(100000 > number))
    {
        int a2 = number % 1000;
        int a3 = a2 / 100;
         WriteLine($"{number} -> {a3}");
    }
    if((number > 99999)&&(1000000 > number))
    {
        int a2 = number % 10000;
        int a3 = a2 / 1000;
         WriteLine($"{number} -> {a3}");
    }
     if((number > 999999)&&(10000000 > number))
    {
        int a2 = number % 100000;
        int a3 = a2 / 10000;
         WriteLine($"{number} -> {a3}");
    }
}  