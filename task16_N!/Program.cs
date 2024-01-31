using System;
using static System.Console; 
Clear();

Write("Введите число N: ");
WriteLine($"N! = {GetFactorial(int.Parse(ReadLine()))}");


int GetFactorial(int number) // Вводимое число N попадает в number
{
    int count = 1;// увеличиваем переменную до number
    int Factorial = 1; // сохраняем сюда произведение после каждого круга 
    while(count <= number)
    {
        Factorial = Factorial * count;
        count++;
    }
    return Factorial;
}
// ВАРИАНТ ПРЕПОДОВАТЕЛЯ 
// int Factorial(int number)
//  {
//      int p =1;
//      for(int i = 2; i <= number; i++)
//      {
//          p*=i;
//      }    

//   }