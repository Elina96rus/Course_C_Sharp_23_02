Console.WriteLine("Введите ваше число");
int N = int.Parse(Console.ReadLine()!);
int b = 2;
while(b <= N){
    if ((b % 2) == 0)
    Console.Write($"{b} ");
    b ++;
}

