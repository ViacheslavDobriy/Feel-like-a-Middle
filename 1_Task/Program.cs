// Показать таблицу квадратов чисел от 1 до N

int GetNumber()
{
    Console.WriteLine("Введите число N: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int UserN = GetNumber();
for(int i =1; i<=UserN;i++)
{
    Console.WriteLine($"{i} * {i} = {i*i}");
}
