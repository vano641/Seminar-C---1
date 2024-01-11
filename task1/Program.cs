Console.Clear();
Console.Write("Введите А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());

if(A==B*B)
{
    Console.WriteLine("А это квадрат В");
}
else
{
    Console.WriteLine("A НЕ квадрат В");
}