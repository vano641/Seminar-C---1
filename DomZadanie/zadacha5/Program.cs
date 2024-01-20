using System;
using static System.Console; 
Clear();

Write("Введите трехзначное число А: ");
int number = int.Parse(Console.ReadLine());

if(number < 100) 
{
    WriteLine("вы ввели не Трехзначное число");
}
else
{   
    if(number > 999)
    {
    WriteLine("вы ввели не Трехзначное число");
    }

        else
        {
            int a1 = number/10;
            int a2 = a1 % 10;
            WriteLine($"{number} -> {a2}");
        }
}        