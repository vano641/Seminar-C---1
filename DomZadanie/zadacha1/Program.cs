Console.Clear();
Console.Write("Введите А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());

if(A > B)
{
    Console.WriteLine("А больше В");
}
if(A < B)
{
    Console.WriteLine("А меньше В");
}
if(A == B)
{
    Console.WriteLine("А равно В");
}