// Найти сумму элементов от M до N, N и M заданы
Console.WriteLine("enter a number 1: ");
int M = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("enter a number 2: ");
int N = int.Parse(Console.ReadLine()??"0");
int curr = Math.Min(N,M);
int max = Math.Max(N,M);
int sum = 0;
void PrintCurrentNumber ( int N, int M)
{
    sum+=curr;
    curr++;
    if(curr<=max)
    PrintCurrentNumber(N,M);
}

PrintCurrentNumber(N,M);
Console.Write($"summ elements in interval ({M} - {N}) = {sum}");