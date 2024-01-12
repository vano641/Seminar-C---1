Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

if(A % 2 == 0)
{
    Console.WriteLine("Число А - четное.");
}
else
{
    Console.WriteLine("Число А - НЕ четное");
}