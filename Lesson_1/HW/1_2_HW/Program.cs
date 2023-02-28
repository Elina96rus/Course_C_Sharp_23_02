Console.WriteLine("Введите ваши числa");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
if(a > b&&a > c)
{
    Console.Write("Максимальное число " + $"{a}" );
}
else if(b > a&&b > c)
{
    Console.Write("Максимальное число " + $"{b} ");
}
else if(c > a&&c > b)
{
    Console.Write("Максимальное число " + $"{c} ");
}