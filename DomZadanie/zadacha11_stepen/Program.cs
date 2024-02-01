// Напишите цикл, который принимает на вход 2 числа (А и В)
// и возводит число А в натуральную степень В
// 3,5 => 243; 2,4 => 16

// МОЕ РЕШЕНИЕ

using System;
using static System.Console; 
Clear();

Write("Введите число A: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
int res = Degree(A, B);        
WriteLine($"A^B = {res}");


int Degree(int numberA, int numberB)
{
    int result=Convert.ToInt32(Math.Pow(numberA,numberB));
    return result;
}
// РЕШЕНИЕ ПРЕПОДОВАТЕЛЯ
//{
//     if(numberB==0)
//      {
//          return 1;
//      }
//      int result = x;
//      for(int i = 2; i <= y; i++)
//      {
//          result *= x;
//      }
//      retun result;
//}