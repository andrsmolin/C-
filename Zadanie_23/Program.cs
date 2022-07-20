void Cube()
{
    Console.WriteLine("Введите число для построение ряда");
    int x = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= x; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Cube();