Console.Clear();
Console.Write("Введите номер дня недели: ");
int A = int.Parse(Console.ReadLine());

if(A>7 || A<1)
{
    Console.WriteLine("Дня недели с таким номером нет!");
    return;// если не прекратить работу, при не верновводе, то алгорим продолжит
}
if(A > 5) // и напишет в консоли "выходной"
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("рабочий день");
}