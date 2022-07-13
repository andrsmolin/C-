Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"Введенное число {a} - четное");
}
else
{
    Console.WriteLine($"Введенное число {a} - нечетное");
}