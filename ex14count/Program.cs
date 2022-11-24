Console.ResetColor();
Console.Write("Введите число: ");

string str = Console.ReadLine()!.Trim();

int n;

if (int.TryParse(str, out n))
{
    Console.WriteLine("");
    Console.WriteLine("Результат: " + intLenght(n));

    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("* для завершения задачи нажмите любую клавишу...");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("err: несоответствие типу integer");
}

int intLenght (int n)
{
    n = Math.Abs(n);
    int rezult = 0;
    do
    {
        n /=10;
        rezult++;
    } while (n>0);
    return rezult;
}
