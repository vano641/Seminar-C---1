Console.Clear();
Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());
int sqr=number*number;
Console.WriteLine($"Квадрат числа = {sqr}");

int sqr1=Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа второй способ = {sqr1}");

