﻿int GetQuarterNumber(int x, int y)
{
    Console.WriteLine("GetQuarterNumber: " + x + " " + y);

    if (x == 0 | y == 0)
    return -1;

    if (x>0 && y>0)
    return 1;

    if (x<0 && y>0)
    return 2;

    if (x<0 && y<0)
    return 3;

    if (x>0 && y<0)
    return 4;
}

Console.WriteLine("Введите Х:");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите У:");
int y = int.Parse(Console.ReadLine()!);

int result = GetQuarterNumber(x, y);

if (result>0)
Console.WriteLine("Номер четверти, в котором лежит точка: " + result);
else
Console.WriteLine("Неверные вводные данные");