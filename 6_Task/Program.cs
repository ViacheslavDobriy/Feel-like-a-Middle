// Подсчитать сумму цифр в числе

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int UserNumber = GetNumber();
int result = 0;
while(UserNumber>=1)
{
    result = result + UserNumber%10;
    UserNumber=UserNumber/10;
}
Console.WriteLine($"Сумма цифр в введенном числе равна {result}");
