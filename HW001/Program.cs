// Показать натуральные числа от 1 до N, N задано
Console.WriteLine("enter a number");
int N = int.Parse(Console.ReadLine()??"0");
int curr = 1;
void PrintCurrentNumber ( int N)
{
    Console.Write($"{curr} ");
    curr++;
    if(curr<=N)
    PrintCurrentNumber(N);
}

PrintCurrentNumber(N);