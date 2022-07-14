void Weekend(int i)
{
    string[] week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
    if (i < 6)
    {

        Console.WriteLine($"{week[i - 1]} не выходной");
    }
    else if (i < 8)
    {
        Console.WriteLine($"{week[i - 1]} - выходной!!!");
    }
    else
    { Console.WriteLine("Проверьте правильность написания числа"); }

}

Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
Weekend(a);