using System;
using static System.Console; // Использование функций класса Console,
// без вызова этого класса в каждой строке.
Clear();
int number = new Random().Next(10, 100); // случайное число в диапазое от 10-99 макс 
// значения не включается в диапазо, поэтому берем 100
int a1 = number/10; // чтобы взять первую цифру случайного числа 
int a2 = number %10; // чтобы взять вторую цифру случайного числа
if(a1>a2)
{
    WriteLine($"{number} -> {a1}"); // using static System.Console;=>не нужно писать Console.WriteLine
}
else
{
    WriteLine($"{number} -> {a2}");
}

