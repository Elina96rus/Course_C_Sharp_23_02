Console.WriteLine("Введите ваше число");
int a = int.Parse(Console.ReadLine()!);
if ((a % 2) == 0)
{
    Console.Write($"{a} " + "четное число");
}
else if((a % 2) != 0)
{
    Console.Write($"{a} " + "нечетное число");
}