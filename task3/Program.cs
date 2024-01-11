Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
int count = -A;

while (count <= A)
{
Console.Write($"{count} ");
count = count + 1;
}