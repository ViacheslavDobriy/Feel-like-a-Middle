// Написать программу вычисления произведения чисел от 1 до N

int GetNumber()
{
    Console.WriteLine("Введите число N: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int Multiple(int number)
{
    int result = 1;
    for(int i = 1 ; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}
int UserNumber = GetNumber();
Console.WriteLine($"Произведение всех чисел от 1 до {UserNumber} = {Multiple(UserNumber)}");