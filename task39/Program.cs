// С ПОМОЩЬЮ РЕКУРСИИ
// Напишите программу, которая на вход принимает Два числа А и В
// и возводит число А в целую степень В 
// А = 3
// В = 5 => 243(3^5)

using System;
using static System.Console;
Clear();

Write("введите M: ");
int m = int.Parse(ReadLine());

Write("введите N: ");
int n = int.Parse(ReadLine());
WriteLine(Result(m,n));

int Result(int number, int degree)
{
    if(degree == 0) return 1; // если передали Степень = 0, то вернем 1
    if(degree == 1) return number; // пока степень не достигла 1, и вернем само число
    
    return(number * Result(number, degree - 1));
    
}
