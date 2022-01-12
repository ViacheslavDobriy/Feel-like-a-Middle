// Возведите число А в натуральную степень B используя цикл

int GetNumberA()
{
    Console.WriteLine("Введите число A: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int GetNumberB()
{
    Console.WriteLine("Введите степень числа A: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int GiveResult(int number, int Pow)
{
    int Result = 1;
    for(int i = 1; i<=Pow; i++)
    {
        Result=Result*number;
    }
    return Result;
}
int UserA = GetNumberA();
int UserB = GetNumberB();
Console.WriteLine($"Результатом возведения числа {UserA} в {UserB} степень является - {GiveResult(UserA,UserB)}");
