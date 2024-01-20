using System;
using static System.Console; 
Clear();
Write("Введите А: ");
int A = int.Parse(ReadLine());
Write("Введите B: ");
int B = int.Parse(ReadLine());
// Первый способ Мой, через переменную
int a1 = A / B;

if(B * a1 == A)
{
    WriteLine($"В кратно А");
}
else
{
    int a2 = A - B * a1;
    WriteLine($"В не кратно А, остаток = {a2}");
}
// Способ Преподователя через взятия остатка от деления А%В
if(A % B==0)
{
    WriteLine("Кратно");
}
else
{
    WriteLine($"не кратно {A % B}");
}