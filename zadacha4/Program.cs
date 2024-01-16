Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

int count = 1;

while(count <= A)
{
    if(count % 2 == 0)
    {
        Console.Write($"{count} ");
        count++;
    }
    else
    {
        count++;
    }
    
}