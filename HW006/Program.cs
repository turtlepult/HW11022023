// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("enter a number");
int N = int.Parse(Console.ReadLine()??"0");
int curr = 1;
int prod = 1;
void PrintCurrentNumber (int N)
{
    prod*=curr;
    curr++;
    if(curr<=N)
    PrintCurrentNumber(N);
}

PrintCurrentNumber(N);
Console.Write($"{prod} ");