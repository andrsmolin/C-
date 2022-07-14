void Number(int number)
{
    if (number >= 100)
    {
        if (number < 1000)
        {
            int ones = number % 10;
            Console.WriteLine(ones);
        }
        else if (number < 10000)
        {
            int tens = number / 10 % 10;
            Console.WriteLine(tens);
        }
        else
        {
            int hundreds = number / 100 % 10;
            Console.WriteLine(hundreds);
        }
    }
    else
    {
        Console.WriteLine("У этой цифры нет третьего чиcла");
    }
}

Random rand = new Random();
int num = rand.Next(1, 100000);
Console.WriteLine(num);
Number(num);

