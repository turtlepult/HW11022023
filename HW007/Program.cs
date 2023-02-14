//Написать программу возведения числа А в целую стень B
Console.WriteLine("Введите основание: ");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите показатель степени: ");
int b = int.Parse(Console.ReadLine()??"0");
int result = 1;
int Stepen(int a, int b)
{
    if (b>0)
    {
        result *=a;
        b--;
        Stepen(a,b);
    }
    return result;
}
Stepen(a,b);
Console.WriteLine(result);