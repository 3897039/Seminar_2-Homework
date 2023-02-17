// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5  78 -> третьей цифры нет  32679 -> 6

int Prompt(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int ThirdDigit(int number)
{
    while(number > 999)
    {
        number = number / 10;
    }
    return (number % 10);
}

bool ValidateNum(int number)
{
    if(number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
        return true;
}

int number = Prompt("Введите число -> ");
if(ValidateNum(number))
{
    Console.WriteLine(ThirdDigit(number));
}
