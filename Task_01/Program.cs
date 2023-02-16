// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

int Prompt(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if(num >= 100 && num < 1000)
    {
        return true;
    }
    Console.WriteLine("Это число не трёхзначное");
    return false;
}
int number = Prompt("Введите трёхзначное число ");
if(Validate(number))
{
    int second = number/ 10 % 10;
    Console.WriteLine($"Вторая цифра числа {number} -> {second}");
}