void Abcba(int number)
{
    int[] array = new int[5];
    int power = 1;
    for (int i = 0; i < 5; i++)
    {
        array[i] = number / power % 10;
        power *= 10;
    }
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine($"Введенное число {number} - палиндром");
    }
    else
    {
        Console.WriteLine($"Введенное число {number} - не палиндром");
    }
}

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
Abcba(a);

