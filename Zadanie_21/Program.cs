﻿void Vector()
{
    Console.WriteLine("Введите координату х первой точки");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату у первой точки");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z первой точки");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х второй точки");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату у второй точки");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z второй точки");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double result = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2);
    Console.WriteLine($"Результат - {result}");
}
Vector();