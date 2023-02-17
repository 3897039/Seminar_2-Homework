// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да   7 -> да      1 -> нет

int Prompt(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

bool Weekend(int DayOfWeek)
{
    if(DayOfWeek > 5)
    {
        return true;
    }
    return false;
}

bool DayNum(int num)
{
    if(num > 0 && num < 8 )
    {
        return true;
    }
    Console.WriteLine("Такого дня недели нет");
    return false;
}

int DayOfWeek = Prompt("Введите номер дня недели -> ");
if(DayNum(DayOfWeek))
{
    if(Weekend(DayOfWeek))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

