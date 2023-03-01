Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);

void Div(int N){
    if (N % 7 == 0 && N % 23 == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine("Некратно");
}
Div(N);