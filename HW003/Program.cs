// Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("enter a number 1: ");
int M = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("enter a number 2: ");
int N = int.Parse(Console.ReadLine()??"0");
int curr = Math.Min(N,M);
int max = Math.Max(N,M);
void PrintCurrentNumber ( int N, int M)
{
    Console.Write($"{curr} ");
    curr++;
    if(curr<=max)
    PrintCurrentNumber(N,M);
}

PrintCurrentNumber(N,M);