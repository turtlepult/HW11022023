
// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
int ValueEnter(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}
int p = 0;
int FakeFibbo(int first, int second, int n, int p)
{ 
    if (n==n)
    {
        Console.Write($"{first} {second}");
        n--;
    }
    else if(n>0)
    {
        p = (n-1)+(n-2);
        Console.Write($"{p} ");
        n--;
        FakeFibbo(first,second,n,p);
    }
return n;
}

int first = ValueEnter("enter a first number");
int second = ValueEnter("enter a second number");
int n = ValueEnter("enter the number of digits");
FakeFibbo(first,second,n,p);