Console.Clear();
Console.Write("Введите А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите C: ");
int C = int.Parse(Console.ReadLine());

int max = 0;

if(A > max)
{
    max = A;
}
if(B > max)
{
    max = B;
}
if(C > max)
{
    max = C;
}
// в тренажере надо было написать "return max;" тут, в VScode работать не будет
Console.WriteLine($"максимальное число = {max}");