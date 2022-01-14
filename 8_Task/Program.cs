//Показать кубы чисел, заканчивающихся на четную цифру

int GetNumber()
{
    Console.WriteLine("Введите число, до которого нужно показать кубы четных чисел: ");
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
void ShowCub(int number)
{
    for(int i = 2; i <=number; i++)
    {
        if(i%2==0)
        {
            Console.WriteLine($"{i}^3 = {i*i*i} ");
        }
    }
}
int UserN = GetNumber();
ShowCub(UserN);