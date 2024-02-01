//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11; 82 -> 10; 9012 -> 12

using System;
using static System.Console; 
Clear();

Write("Введите число A: ");
int A = int.Parse(ReadLine());
int result = SumNumber(A);        
WriteLine($"Сумма цифр = {result}");


int SumNumber(int numberA)
{
    int sum = 0;
    while(numberA > 0)
    {
        sum = sum + numberA % 10; // sum+=numberA%10;
        numberA = numberA / 10; // numberA/=10;
    }
    return sum;
}