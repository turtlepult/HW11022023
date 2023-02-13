// Показать натуральные числа от N до 1, N задано
Console.WriteLine("enter a number");
int N = int.Parse(Console.ReadLine()??"0");
int curr = N;
void PrintCurrentNumber (int N)
{
    Console.Write($"{curr} ");
    curr--;
    if(curr>=1)
    PrintCurrentNumber(N);
}

PrintCurrentNumber(N);