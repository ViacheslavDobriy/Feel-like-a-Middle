// Найти кубы чисел от 1 до N

int GetNumber()
{
    Console.WriteLine("Введите число N: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int UserN = GetNumber();
for(int j=1; j<=UserN;j++)
{
    Console.WriteLine($" {j}^3 = {j*j*j}");
}
