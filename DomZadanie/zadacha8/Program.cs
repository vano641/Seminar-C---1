using System;
using static System.Console; 
Clear();

Write("Введите число : ");
int number = int.Parse(Console.ReadLine());

 if((number < 10000 || number > 99999)) 
      {
         Console.WriteLine("Число не пятизначное");
        
      }
      
      int a1 = number / 10000;
      int b = number - a1 * 10000;
      int a2 = b / 1000;
      int b1 = b - a2 * 1000;
      int a3 = b1 / 100;
      int b2 = b1 - a3 * 100;
      int a4 = b2 / 10;
      int a5 = b2 % 10;
      
      if((a1 == a5)&&(a2 == a4))
      {
        Console.WriteLine("True");
      }
      else
      {
        Console.WriteLine("False");
      }
