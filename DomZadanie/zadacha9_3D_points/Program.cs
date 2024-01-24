using System;
using static System.Console;

Clear();
Write("Введите координату Х1: ");
int x1 = int.Parse(ReadLine());
Write("Введите координату Y1: ");
int y1 = int.Parse(ReadLine());
Write("Введите координату Z1: ");
int z1 = int.Parse(ReadLine());

Write("Введите координату Х2: ");
int x2 = int.Parse(ReadLine());
Write("Введите координату Y2: ");
int y2 = int.Parse(ReadLine());
Write("Введите координату Z2: ");
int z2 = int.Parse(ReadLine());


double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// т.к мы применяем Квадр.Кор то применяем метод double
// Для Квадр корня метод Math.Sqrt()
// Для возведения в степень метод Math.Pow(...-...,2(степень))


WriteLine($"Длинна отрезка = {d:f2}");
// после переменной d (которя являетс double) ставим : и далее 
// указываем служебный параметр f4. f- говорит о том, что нашу переменную нужно округлить
// а 4 - говорит о том до скольки знаков после ,
// округление происходит согластно правилам математики
 