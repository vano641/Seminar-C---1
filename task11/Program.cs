using System;
using static System.Console;

Clear();
Write("Введите номер Координатной четверти: ");
int coordinate = int.Parse(ReadLine());
// Мое Решение
if((coordinate < 1)||(coordinate > 4))
{
    WriteLine("Не верный номер координатной четверти");
}
else
{
    if(coordinate == 1)
    {
        WriteLine("x>0 y>0");
    }
    if(coordinate == 2)
    {
        WriteLine("x<0 y>0");
    }
    if(coordinate == 3)
    {
        WriteLine("x<0 y<0");
    }
    if(coordinate == 4)
    {
        WriteLine("x>0 y<0");
    }
}
// Решение Преподавателя
// оператор switch удобно использовать когда за ранее определен набор данный
// в данном случае это 4ре четверти
switch(coordinate) 
{ // в рамках этого оператора мы Передаем нашу переменную (coordinate)
// дальше он позволяет использовать знач. этой переменной для выбора необходимого действия
    case 1: // для этого есть case который определяет чему равна наша переменная
    {
        WriteLine("x>0 y>0");
        break; // на этом действия закончились (выходим из оперетора выбора)
    }
    case 2:
    {
        WriteLine("x<0 y>0");
        break;
    }
    case 3:
    {
        WriteLine("x<0 y<0");
        break;
    }
    case 4:
    {
        WriteLine("x>0 y<0");
        break;
    }
    default: // это услови отработает если нет ни одного правильного решения
    {
        WriteLine("Не верная четверть");
        break;
    }
}