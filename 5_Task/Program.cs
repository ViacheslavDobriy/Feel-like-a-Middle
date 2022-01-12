// Определить количество цифр в числе

double GetNumber()
{
    Console.WriteLine("Введите число : ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
double UserN = GetNumber();
int i =1;
for(i=1; Math.Round(UserN/10-0,5)>=1;i++)
{
    UserN=Math.Round(UserN/10-0,5);
}
Console.WriteLine($"Всего в введенном числе {i} цифр");