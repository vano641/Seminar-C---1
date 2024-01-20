using System;
using static System.Console;
Clear();
Write("Введите А: ");
int A = int.Parse(ReadLine());
Write("Введите B: ");
int B = int.Parse(ReadLine());

if(A==B*B) // Математический метод вычисления Квадрата
{
WriteLine("А это квадрат В");
}
else
{
    if(Math.Pow(A,2)==B) // Метод встроенных функций вычисления квадрата
    {
        WriteLine("B это квадрат A");
    }
    else
    {
        WriteLine("не квадрат");
    }
}