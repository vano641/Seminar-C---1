using System;
using static System.Console;

Clear();
Write("Введите координату Х: ");
int x = int.Parse(ReadLine());
Write("Введите координату Y: ");
int y = int.Parse(ReadLine());

if(x>0&&y>0)
{
    WriteLine("1ая четверть");
}
if(x<0&&y>0)
{
    WriteLine("2ая четверть");
}
if(x<0&&y<0)
{
    WriteLine("3ая четверть");
}
if(x>0&&y<0)
{
    WriteLine("4ая четверть");
}