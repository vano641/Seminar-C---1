using System;
using static System.Console; 
Clear();
int number = new Random().Next(100, 1000);
int a1 = number/100;
int a2 = number%10;
WriteLine($"{number} -> {a1}{a2}");// первый способ через доп. переменные а1,а2
WriteLine($"{number} -> {(number / 100) * 10 + number % 10}");//способ без доп. переменных(в 5 строк)