//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, 
//b2 = 4, k2 = 9    -> (-0,5; -0,5)

using System;
using static System.Console;
Clear();

Write("Введите b1,k1,b2,k2 через пробел: ");
string[] nums = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

// в метод передаем наши параметры считанные с консоли и сразу преобразовываем их в тип double
double[] point = GetPoint(double.Parse(nums[0]),double.Parse(nums[1]),double.Parse(nums[2]),double.Parse(nums[3]));
WriteLine($"[{String.Join(";",point)}]");


// Метод который возвращает координаты точки ( в виде массива из 2ух элементов)
double[] GetPoint(double b1, double k1, double b2, double k2)// в качестве параметров передаем наши значения
{
    double[] point = new double[2];// результирующий массив из 2ух элементов (Х и У)
    point[0] = (b2 - b1)/(k1 - k2);// рассчитаем координату Х для этого преобразуем в систему уравнений
    point[1] = point[0] * k1 + b1;// Рассчитаем координату У используем уравнение прямой( в качестве Х подставляем point[0])

    return point;
}