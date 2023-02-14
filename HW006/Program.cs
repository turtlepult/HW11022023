//Написать программу вычисления функции Аккермана
int FunAcc(int n, int m)
{
    while (n != 0)
    {
        if (m = 0)
        {
            m /= 1;
        }
        else
        {
            m /= FunAcc(n, m - 1);
        }
    n /= n - 1;
    }
    
    return m + 1;
}
int xxx = FunAcc(2, 4);
Console.WriteLine(xxx);