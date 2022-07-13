Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int e = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a < b)
{
    if (b > e)
    {
        max = b;
    }
    else
    {
        max = e;
    }
}
Console.WriteLine($"Максимальное число - {max}");
