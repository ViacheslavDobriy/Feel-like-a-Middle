// Найти сумму чисел от 1 до А

int GetNumber()
{
    Console.WriteLine("Введите число A: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int ResultSum(int NumberA)
{
    int result = 0;
    for(int k=1;k<=NumberA;k++)
    {
        result=result+k;
    }
    return result;
}
int UserA = GetNumber();
Console.WriteLine($"Сумма всех чисел от 1 до A = {ResultSum(UserA)}");