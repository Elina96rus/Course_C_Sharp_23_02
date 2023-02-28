Console.WriteLine("Введите ваши числa");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if(a > b)
{
    Console.Write("Максимальное число " + $"{a}" + ". Минимальное число, " + $"{b} ");
}
else if(b > a)
{
    Console.Write("Максимальное число " + $"{b} " + ". Минимальное число " + $"{a} ");
}